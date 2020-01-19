using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Mono.Cecil;

namespace apidiff
{

/// <summary>
/// Extract the public API of a C# assembly, to make changes
/// to the API easily diffable.
/// </summary>
public static class ApiWriter
{
    public static void WriteApi(string assemblyPath, string outputPath)
    {
        var resolver = new DefaultAssemblyResolver();
        resolver.AddSearchDirectory(Path.GetDirectoryName(assemblyPath));

        var config = new ReaderParameters();
        config.AssemblyResolver = resolver;

        var module = ModuleDefinition.ReadModule(assemblyPath, config);
        Console.WriteLine($"Opened module {module.Name}");

        var types = module.Types
            .Where(t => t.IsPublic)
            .OrderBy(t => t.Name)
            .ToList();

        var count = types.Count;
        Console.WriteLine($"Found {types.Count} public root types");
        if (count == 0) return;

        var moduleOutputPath = Path.Combine(outputPath, Path.GetFileNameWithoutExtension(module.Name));
        if (!Directory.Exists(moduleOutputPath)) {
            Directory.CreateDirectory(moduleOutputPath);
        }

        foreach (var type in types) {
            WriteType(type, 0, moduleOutputPath);
        }
    }

    // -------- Main Types --------

    static void WriteType(TypeDefinition type, int indent, string basePath)
    {
        var namespacePath = Path.Combine(basePath, type.Namespace.Replace(".", "/"));
        if (!Directory.Exists(namespacePath)) {
            Directory.CreateDirectory(namespacePath);
        }

        var filename = RemoveGenericSuffix(type.Name);
        if (type.HasGenericParameters) {
            filename += "<" + string.Join(", ", type.GenericParameters.Select(p => FormatTypeName(p))) + ">";
        }
        filename += ".cs";

        var filePath = Path.Combine(namespacePath, filename);
        if (File.Exists(filePath)) {
            Console.WriteLine($"WARNING File already exists: {filePath}");
        }

        using (var stream = File.Open(filePath, FileMode.Create, FileAccess.Write)) {
            using (var output = new StreamWriter(stream)) {
                foreach (var imported in ImportedNamespaces) {
                    WriteIndent(indent, output);
                    output.WriteLine($"using {imported};");
                }

                output.WriteLine();

                WriteIndent(indent, output);
                output.Write("namespace ");
                output.WriteLine(type.Namespace);

                WriteIndent(indent, output);
                output.WriteLine("{");

                output.WriteLine();

                WriteType(type, indent, output);

                output.WriteLine();

                WriteIndent(indent, output);
                output.WriteLine("}");
            }
        }
    }

    static void WriteType(TypeDefinition type, int indent, TextWriter output)
    {
        if (type.IsEnum) {
            WriteEnum(type, indent, output);
        } else if (type.BaseType != null && type.BaseType.FullName == "System.MulticastDelegate") {
            WriteDelegate(type, indent, output);
        } else if (type.IsClass || type.IsValueType || type.IsInterface) {
            WriteClassStructOrInterface(type, indent, output);
        }
    }

    static void WriteClassStructOrInterface(TypeDefinition type, int indent, TextWriter output)
    {
        WriteIndent(indent, output);

        output.Write(FormatTypeAccess(type));
        
        if (type.IsSealed && type.IsAbstract) output.Write(" static");
        else if (type.IsSealed && !type.IsValueType) output.Write(" sealed");
        else if (type.IsAbstract && !type.IsInterface) output.Write(" abstract");
        
        if (type.IsValueType) output.Write(" struct");
        else if (type.IsClass) output.Write(" class");
        else if (type.IsInterface) output.Write(" interface");
        else throw new Exception("Type not a class, struct or interface.");

        output.Write(" " + FormatTypeName(type, forceNoNamespace: true));

        var hasBaseType = type.BaseType != null && type.BaseType.FullName != "System.Object" && type.BaseType.FullName != "System.ValueType";
        if (hasBaseType || type.HasInterfaces) {
            var extends = type.Interfaces.Select(i => i.InterfaceType);
            if (hasBaseType) extends = extends.Prepend(type.BaseType);
            output.Write(" : " + string.Join(", ", extends.Select(t => FormatTypeName(t))));
        }

        output.WriteLine();

        WriteIndent(indent, output);
        output.WriteLine("{");

        var fields = type.Fields
            .Where(f => (f.IsPublic || f.IsFamily) && !f.IsSpecialName)
            .OrderBy(f => f.Name);
        var props = type.Properties
            .Where(p => { var a = GetMoreAccessibleAccessor(p); return a.IsPublic || a.IsFamily; })
            .OrderBy(p => p.Name);
        var events = type.Events
            .Where(e => e.AddMethod.IsPublic || e.AddMethod.IsFamily)
            .OrderBy(e => e.Name);
        var methods = type.Methods
            .Where(m => (m.IsPublic || m.IsFamily) && (!m.IsSpecialName || m.IsConstructor) && m.Name != "Finalize")
            .OrderBy(m => m, MethodComparer.Instance);

        WriteMembers(
            fields.Where(m => m.IsStatic), 
            WriteField, indent, output
        );
        WriteMembers(
            props.Where(m => GetMoreAccessibleAccessor(m).IsStatic), 
            WriteProperty, indent, output
        );
        WriteMembers(
            events.Where(m => m.AddMethod.IsStatic), 
            WriteEvent, indent, output
        );
        WriteMembers(
            methods.Where(m => m.IsStatic), 
            WriteMethod, indent, output
        );

        WriteMembers(
            fields.Where(m => !m.IsStatic), 
            WriteField, indent, output
        );
        WriteMembers(
            props.Where(m => !GetMoreAccessibleAccessor(m).IsStatic), 
            WriteProperty, indent, output
        );
        WriteMembers(
            events.Where(m => !m.AddMethod.IsStatic), 
            WriteEvent, indent, output
        );

        WriteMembers(
            methods.Where(m => !m.IsStatic && m.IsConstructor), 
            WriteMethod, indent, output
        );
        WriteMembers(
            methods.Where(m => !m.IsStatic && !m.IsConstructor), 
            WriteMethod, indent, output
        );

        foreach (var nested in type.NestedTypes.OrderBy(t => t.Name)) {
            if (!nested.IsNestedPublic && !nested.IsNestedFamily) continue;
            WriteType(nested, indent + 1, output);
            output.WriteLine();
        }

        WriteIndent(indent, output);
        output.WriteLine("}");
    }

    static void WriteMembers<T>(IEnumerable<T> members, Action<T, TextWriter> writer, int indent, TextWriter output)
        where T : IMemberDefinition
    {
        if (members.Any()) {
            foreach (var member in members) {
                WriteIndent(indent + 1, output);
                writer(member, output);
            }
            output.WriteLine();
        }
    }

    static void WriteEnum(TypeDefinition type, int indent, TextWriter output)
    {
        WriteIndent(indent, output);

        output.Write(FormatTypeAccess(type));
        output.Write(" enum");
        output.Write(" " + type.Name);

        var valueField = type.Fields.FirstOrDefault(f => !f.IsStatic);
        if (valueField != null && valueField.FieldType.FullName != "System.Int32") {
            output.Write(" : " + FormatTypeName(valueField.FieldType));
        }

        output.WriteLine();

        WriteIndent(indent, output);
        output.WriteLine("{");

        foreach (var field in type.Fields.OrderBy(f => f.Constant)) {
            if (!field.IsStatic) continue;
            WriteIndent(indent + 1, output);
            output.WriteLine(field.Name + " = " + FormatConstant(field.Constant) + ",");
        }

        WriteIndent(indent, output);
        output.WriteLine("}");
    }

    static void WriteDelegate(TypeDefinition type, int indent, TextWriter output)
    {
        WriteIndent(indent, output);

        output.Write(FormatTypeAccess(type));
        output.Write(" delegate");

        var invoke = type.Methods.FirstOrDefault(m => m.Name == "Invoke");
        output.Write(" " + FormatTypeName(invoke.ReturnType));

        output.Write(" " + type.Name);

        output.Write("(" + string.Join(", ", invoke.Parameters.Select(FormatParameter)) + ")");

        output.WriteLine(";");
    }

    // -------- Members --------

    static void WriteField(FieldDefinition field, TextWriter output)
    {
        if (field.IsStatic)
            output.Write("static ");

        if (field.IsPublic) {
            output.Write("public ");
        } else if (field.IsAssembly) {
            output.Write("internal ");
        } else if (field.IsFamily) {
            output.Write("protected ");
        } else if (field.IsFamilyOrAssembly) {
            output.Write("protected internal ");
        }

        output.Write(FormatTypeName(field.FieldType) + " ");
        output.Write(field.Name);

        if (field.HasConstant) {
            output.Write(" = " + FormatConstant(field.Constant));
        }

        output.WriteLine(";");
    }

    static void WriteProperty(PropertyDefinition property, TextWriter output)
    {
        var eitherMethod = property.GetMethod ?? property.SetMethod;
        var otherMethod = eitherMethod == property.SetMethod ? null : property.SetMethod;

        if (eitherMethod.IsStatic)
            output.Write("static ");

        string mainAccess;
        if (otherMethod == null) {
            mainAccess = FormatMethodAccess(eitherMethod);
        } else {
            mainAccess = FormatMethodAccess(GetMoreAccessibleAccessor(property));
        }
         output.Write(mainAccess + " ");

         output.Write(FormatTypeName(property.PropertyType) + " ");

        if (property.Name == "Item" && property.HasParameters) {
             output.Write("this[" + string.Join(", ", property.Parameters.Select(FormatParameter)) + "]");
        } else {
             output.Write(property.Name);
        }

        output.Write(" { ");

        if (property.GetMethod != null) {
            var access = FormatMethodAccess(property.GetMethod);
            if (access != mainAccess) output.Write(access + " ");
            output.Write("get; ");
        }
        if (property.SetMethod != null) {
            var access = FormatMethodAccess(property.SetMethod);
            if (access != mainAccess)  output.Write(access + " ");
             output.Write("set; ");
        }

        output.Write("}");

        if (property.HasConstant) {
            output.Write(" = " + FormatConstant(property.Constant));
        }

        output.WriteLine();
    }

    static void WriteEvent(EventDefinition ev, TextWriter output)
    {
        var method = ev.AddMethod;

        if (method.IsStatic)
            output.Write("static ");

        if (method.IsPublic) {
            output.Write("public ");
        } else if (method.IsAssembly) {
            output.Write("internal ");
        } else if (method.IsFamily) {
            output.Write("protected ");
        } else if (method.IsFamilyOrAssembly) {
            output.Write("protected internal ");
        } else if (method.IsFamilyAndAssembly) {
            output.Write("private protected ");
        } else {
            output.Write("private ");
        }

        output.Write("event ");

        output.Write(FormatTypeName(ev.EventType) + " ");

        output.WriteLine(ev.Name + ";");
    }

    static void WriteMethod(MethodDefinition method, TextWriter output)
    {
        if (method.IsStatic)
            output.Write("static ");

        output.Write(FormatMethodAccess(method) + " ");

        if (method.Name == ".ctor") {
            output.Write(RemoveGenericSuffix(method.DeclaringType.Name));
        } else {
            output.Write(FormatTypeName(method.ReturnType) + " ");
            output.Write(method.Name);
            if (method.HasGenericParameters) {
                output.Write("<" + string.Join(", ", method.GenericParameters.Select(p => FormatTypeName(p))) + ">");
            }
        }

        output.WriteLine("(" + string.Join(", ", method.Parameters.Select(FormatParameter)) + ");");
    }

    public class MethodComparer : IComparer<MethodDefinition>
    {
        public static readonly MethodComparer Instance = new MethodComparer();

        public int Compare(MethodDefinition x, MethodDefinition y)
        {
            if (x == y) return 0;

            // First sort by method name
            var value = string.Compare(x.Name, y.Name, true);
            if (value != 0) return value;

            // Then sort by generic parameter count
            value = x.GenericParameters.Count.CompareTo(y.GenericParameters.Count);
            if (value != 0) return value;

            // Then by generic parameter names
            for (int i = 0; i < x.GenericParameters.Count; i++) {
                value = string.Compare(x.GenericParameters[i].Name, y.GenericParameters[i].Name, true);
                if (value != 0) return value;
            }

            // Then sort by parameter count
            value = x.Parameters.Count.CompareTo(y.Parameters.Count);
            if (value != 0) return value;

            // Then by parameter names
            for (int i = 0; i < x.Parameters.Count; i++) {
                value = string.Compare(x.Parameters[i].Name, y.Parameters[i].Name, true);
                if (value != 0) return value;
            }

            // Finally by parameter types
            for (int i = 0; i < x.Parameters.Count; i++) {
                value = string.Compare(x.Parameters[i].ParameterType.FullName, y.Parameters[i].ParameterType.FullName, true);
                if (value != 0) return value;
            }

            //var writer = new StringWriter();
            //writer.Write("- ");
            //WriteMethod(x, writer);
            //writer.Write("- ");
            //WriteMethod(y, writer);
            //Console.WriteLine($"WARNING Method names and parameter types/names match:\n{writer}");

            // This can happen if there are methods that just differ in case,
            // e.g. when the case has been corrected but the old method remains 
            // for backwards compatibility
            return 0;
        }
    }

    // -------- Helpers --------

    const string Indent = "    ";

    static readonly string[] ImportedNamespaces = new string[] {
        "System",
        "System.Collections",
        "System.Collections.Generic",
        "UnityEngine",
    };

    static void WriteIndent(int indent, TextWriter output)
    {
        for (int i = 0; i < indent; i++) {
            output.Write(Indent);
        }
    }

    static string FormatTypeAccess(TypeDefinition type)
    {
        if (type.IsPublic || type.IsNestedPublic) {
            return "public";
        } else if (type.IsNestedAssembly) {
            return "internal";
        } else if (type.IsNestedFamily) {
            return "protected";
        } else if (type.IsNestedFamilyOrAssembly) {
            return "protected internal";
        } else if (type.IsNestedFamilyAndAssembly) {
            return "private protected";
        } else {
            return "private";
        }
    }

    static string RemoveGenericSuffix(string name)
    {
        var apo = name.LastIndexOf('`');
        if (apo >= 0) {
            return name.Substring(0, apo);
        } else {
            return name;
        }
    }

    static string FormatTypeName(TypeReference type, bool forceNoNamespace = false)
    {
        var resolved = type.Resolve() ?? type;

        string name;
        if (type.IsArray) {
            name = type.Name;
        } else {
            name = resolved.Name;
        }

        if (resolved.Namespace == "System") {
            switch (resolved.Name) {
                case "Void":
                    name = name.Replace("Void", "void");
                    break;
                case "Object":
                    name = name.Replace("Object", "object");
                    break;
                case "Boolean":
                    name = name.Replace("Boolean", "bool");
                    break;
                case "Int16":
                    name = name.Replace("Int16", "short");
                    break;
                case "UInt16":
                    name = name.Replace("UInt16", "ushort");
                    break;
                case "Int32":
                    name = name.Replace("Int32", "int");
                    break;
                case "UInt32":
                    name = name.Replace("UInt32", "uint");
                    break;
                case "Int64":
                    name = name.Replace("Int64", "long");
                    break;
                case "UInt64":
                    name = name.Replace("UInt64", "ulong");
                    break;
                case "Single":
                    name = name.Replace("Single", "float");
                    break;
                case "Double":
                    name = name.Replace("Double", "double");
                    break;
                case "Decimal":
                    name = name.Replace("Decimal", "decimal");
                    break;
                case "Byte":
                    name = name.Replace("Byte", "byte");
                    break;
                case "SByte":
                    name = name.Replace("SByte", "sbyte");
                    break;
                case "String":
                    name = name.Replace("String", "string");
                    break;
                case "Char":
                    name = name.Replace("Char", "char");
                    break;
            }
        }

        if (name.EndsWith("&")) {
            name = name.Substring(0, name.Length - 1);
        }

        if (!forceNoNamespace 
                && resolved.Namespace != "" 
                && !ImportedNamespaces.Contains(resolved.Namespace)) {
            if (resolved.Namespace.StartsWith("UnityEngine.")) {
                name = resolved.Namespace.Substring(12) + "." + name;
            } else {
                name = resolved.Namespace + "." + name;
            }
        }

        if (resolved.GenericParameters.Count > 0) {
            name = RemoveGenericSuffix(name);
            if (type is GenericInstanceType instanceType) {
                name += "<" + string.Join(", ", instanceType.GenericArguments.Select(p => FormatTypeName(p))) + ">";
            } else {
                name += "<" + string.Join(", ", resolved.GenericParameters.Select(p => FormatTypeName(p))) + ">";
            }
        }

        return name;
    }

    static string FormatConstant(object constant)
    {
        if (constant == null) {
            return "null";
        } else if (constant is string) {
            return $"\"{constant}\"";
        } else if (constant is bool) {
            return ((bool)constant ? "true" : "false");
        } else {
            return constant.ToString();
        }
    }

    static MethodDefinition GetMoreAccessibleAccessor(PropertyDefinition property)
    {
        if (property.GetMethod == null) {
            return property.SetMethod;
        } else if (property.SetMethod == null) {
            return property.GetMethod;
        }

        var getAccess = GetAccessRank(property.GetMethod);
        var setAccess = GetAccessRank(property.SetMethod);
        return getAccess < setAccess ? property.GetMethod : property.SetMethod;
    }

    static int GetAccessRank(MethodDefinition method)
    {
        if (method.IsPublic) {
            return 1;
        } else if (method.IsAssembly) {
            return 2;
        } else if (method.IsFamily) {
            return 2;
        } else if (method.IsFamilyOrAssembly) {
            return 2;
        } else if (method.IsFamilyAndAssembly) {
            return 3;
        } else {
            return 3;
        }
    }

    static string FormatMethodAccess(MethodDefinition method)
    {
        if (method.IsPublic) {
            return "public";
        } else if (method.IsAssembly) {
            return "internal";
        } else if (method.IsFamily) {
            return "protected";
        } else if (method.IsFamilyOrAssembly) {
            return "protected internal";
        } else if (method.IsFamilyAndAssembly) {
            return "private protected";
        } else {
            return "private";
        }
    }

    static string FormatParameter(ParameterDefinition param)
    {
        var name = "";

        if (param.IsIn && param.IsOut) name += "ref ";
        else if (param.IsIn) name += "in ";
        else if (param.IsOut) name += "out ";

        name += FormatTypeName(param.ParameterType) + " " + param.Name;
        
        if (param.HasConstant) {
            name += " = " + FormatConstant(param.Constant);
        }
        
        return name;
    }
}

}
