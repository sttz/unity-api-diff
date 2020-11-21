using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class Assembly
{
    public string[] allReferences { get; }
    public UnityEditor.Compilation.Assembly[] assemblyReferences { get; internal set; }
    public string[] compiledAssemblyReferences { get; private set; }
    public UnityEditor.Compilation.ScriptCompilerOptions compilerOptions { get; internal set; }
    public string[] defines { get; private set; }
    public UnityEditor.Compilation.AssemblyFlags flags { get; private set; }
    public string name { get; private set; }
    public string outputPath { get; private set; }
    public string rootNamespace { get; private set; }
    public string[] sourceFiles { get; private set; }

    public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, UnityEditor.Compilation.Assembly[] assemblyReferences, string[] compiledAssemblyReferences, UnityEditor.Compilation.AssemblyFlags flags);
    public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, UnityEditor.Compilation.Assembly[] assemblyReferences, string[] compiledAssemblyReferences, UnityEditor.Compilation.AssemblyFlags flags, UnityEditor.Compilation.ScriptCompilerOptions compilerOptions);
    public Assembly(string name, string outputPath, string[] sourceFiles, string[] defines, UnityEditor.Compilation.Assembly[] assemblyReferences, string[] compiledAssemblyReferences, UnityEditor.Compilation.AssemblyFlags flags, UnityEditor.Compilation.ScriptCompilerOptions compilerOptions, string rootNamespace);

}

}
