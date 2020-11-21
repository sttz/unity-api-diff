using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class ScriptCompilerOptions
{
    public string[] AdditionalCompilerArguments { get; set; }
    public bool AllowUnsafeCode { get; set; }
    public UnityEditor.ApiCompatibilityLevel ApiCompatibilityLevel { get; set; }
    public UnityEditor.Compilation.CodeOptimization CodeOptimization { get; set; }
    public bool EmitReferenceAssembly { get; set; }
    public string LanguageVersion { get; internal set; }
    public string[] ResponseFiles { get; set; }
    public string[] RoslynAnalyzerDllPaths { get; set; }
    public string RoslynAnalyzerRulesetPath { get; set; }

    public ScriptCompilerOptions();

}

}
