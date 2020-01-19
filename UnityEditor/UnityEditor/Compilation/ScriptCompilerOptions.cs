using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class ScriptCompilerOptions
{
    public bool AllowUnsafeCode { get; set; }
    public UnityEditor.ApiCompatibilityLevel ApiCompatibilityLevel { get; set; }
    public UnityEditor.Compilation.CodeOptimization CodeOptimization { get; set; }
    public string[] ResponseFiles { get; set; }

    public ScriptCompilerOptions();

}

}
