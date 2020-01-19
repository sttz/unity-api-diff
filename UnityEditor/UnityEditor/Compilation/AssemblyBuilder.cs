using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class AssemblyBuilder
{
    public string[] additionalDefines { get; set; }
    public string[] additionalReferences { get; set; }
    public string assemblyPath { get; private set; }
    public UnityEditor.BuildTarget buildTarget { get; set; }
    public UnityEditor.BuildTargetGroup buildTargetGroup { get; set; }
    public UnityEditor.Compilation.ScriptCompilerOptions compilerOptions { get; set; }
    public string[] defaultDefines { get; }
    public string[] defaultReferences { get; }
    public string[] excludeReferences { get; set; }
    public UnityEditor.Compilation.AssemblyBuilderFlags flags { get; set; }
    public UnityEditor.Compilation.ReferencesOptions referencesOptions { get; set; }
    public string[] scriptPaths { get; private set; }
    public UnityEditor.Compilation.AssemblyBuilderStatus status { get; }

    public event Action<string, UnityEditor.Compilation.CompilerMessage[]> buildFinished;
    public event Action<string> buildStarted;

    public AssemblyBuilder(string assemblyPath, string[] scriptPaths);

    public bool Build();

}

}
