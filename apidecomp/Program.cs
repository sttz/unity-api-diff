using System;
using System.IO;

namespace apidiff
{

class Program
{
    // -------- CLI --------

    static void Main(string[] args)
    {
        if (args.Length != 2) {
            PrintHelp();
            Environment.Exit(1);
        }

        var path = args[0];
        var outputPath = args[1];

        if (!Directory.Exists(path)) {
            Console.WriteLine($"Path is not a directory: {path}");
            PrintHelp();
            Environment.Exit(2);
        }

        var editorPath = Path.Combine(path, "UnityEditor.dll");
        if (!File.Exists(editorPath)) {
            Console.WriteLine($"Could not find UnityEditor.dll assembly at path: {path}");
            PrintHelp();
            Environment.Exit(3);
        }

        var enginePaths = Directory.GetFiles(path, "UnityEngine*.dll");
        if (enginePaths.Length == 0) {
            Console.WriteLine($"Could not find UnityEngine assemblies at path: {path}");
            PrintHelp();
            Environment.Exit(3);
        }

        if (Directory.Exists(outputPath)) {
            var contents = Directory.GetDirectories(outputPath);
            foreach (var dir in contents) {
                if (Path.GetFileName(dir).StartsWith(".")) continue;
                Directory.Delete(dir, true);
            }
        }

        Directory.CreateDirectory(outputPath);

        Console.WriteLine("");
        ApiWriter.WriteApi(editorPath, outputPath);

        foreach (var assembly in enginePaths) {
            Console.WriteLine($"");
            ApiWriter.WriteApi(assembly, outputPath);
        }
    }

    static void PrintHelp()
    {
        Console.WriteLine("Public API Printer");
        Console.WriteLine("usage: apidecomp PATH_TO_ASSEMBLIES OUTPUT_PATH");
    }

    
}

}
