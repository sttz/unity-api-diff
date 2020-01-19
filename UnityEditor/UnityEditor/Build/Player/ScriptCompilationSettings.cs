using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public struct ScriptCompilationSettings
{
    public UnityEditor.BuildTargetGroup group { get; set; }
    public UnityEditor.Build.Player.ScriptCompilationOptions options { get; set; }
    public UnityEditor.BuildTarget target { get; set; }

}

}
