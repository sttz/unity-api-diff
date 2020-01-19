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
    static public event Action<object> compilationFinished;
    static public event Action<object> compilationStarted;

    static public string AssemblyDefinitionReferenceGUIDToGUID(string reference);
    static public UnityEditor.Compilation.Assembly[] GetAssemblies();
    static public UnityEditor.Compilation.Assembly[] GetAssemblies(UnityEditor.Compilation.AssembliesType assembliesType);
    static public string GetAssemblyDefinitionFilePathFromAssemblyName(string assemblyName);
    static public string GetAssemblyDefinitionFilePathFromAssemblyReference(string reference);
    static public string GetAssemblyDefinitionFilePathFromScriptPath(string sourceFilePath);
    static public UnityEditor.Compilation.AssemblyDefinitionPlatform[] GetAssemblyDefinitionPlatforms();
    static public UnityEditor.Compilation.AssemblyDefinitionReferenceType GetAssemblyDefinitionReferenceType(string reference);
    static public string GetAssemblyNameFromScriptPath(string sourceFilePath);
    static public string[] GetPrecompiledAssemblyNames();
    static public string GetPrecompiledAssemblyPathFromAssemblyName(string assemblyName);
    static public string[] GetPrecompiledAssemblyPaths(PrecompiledAssemblySources precompiledAssemblySources);
    static public string[] GetSystemAssemblyDirectories(UnityEditor.ApiCompatibilityLevel apiCompatibilityLevel);
    static public string GUIDToAssemblyDefinitionReferenceGUID(string guid);
    static public UnityEditor.Compilation.ResponseFileData ParseResponseFile(string relativePath, string projectDirectory, string[] systemReferenceDirectories);

    public enum PrecompiledAssemblySources
    {
        All = -1,
        UserAssembly = 1,
        UnityEngine = 2,
        UnityEditor = 4,
        SystemAssembly = 8,
    }

}

}
