using System;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public struct ScriptCompilationSettings
{
    public string[] extraScriptingDefines { get; set; }
    public UnityEditor.BuildTargetGroup group { get; set; }
    public UnityEditor.Build.Player.ScriptCompilationOptions options { get; set; }
    public UnityEditor.BuildTarget target { get; set; }

}

}
