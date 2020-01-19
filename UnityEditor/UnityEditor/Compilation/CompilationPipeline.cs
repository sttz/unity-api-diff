using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public static class CompilationPipeline
{
    static public event Action<string, UnityEditor.Compilation.CompilerMessage[]> assemblyCompilationFinished;
    static public event Action<string> assemblyCompilationStarted;

    static public UnityEditor.Compilation.Assembly[] GetAssemblies();
    static public UnityEditor.Compilation.Assembly[] GetAssemblies(UnityEditor.Compilation.AssembliesType assembliesType);
    static public string GetAssemblyDefinitionFilePathFromAssemblyName(string assemblyName);
    static public string GetAssemblyDefinitionFilePathFromScriptPath(string sourceFilePath);
    static public UnityEditor.Compilation.AssemblyDefinitionPlatform[] GetAssemblyDefinitionPlatforms();
    static public string GetAssemblyNameFromScriptPath(string sourceFilePath);
    static public string[] GetPrecompiledAssemblyNames();
    static public string GetPrecompiledAssemblyPathFromAssemblyName(string assemblyName);

}

}
