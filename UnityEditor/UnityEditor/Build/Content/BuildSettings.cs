using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct BuildSettings
{
    public UnityEditor.Build.Content.ContentBuildFlags buildFlags { get; set; }
    public UnityEditor.BuildTargetGroup group { get; set; }
    public UnityEditor.BuildTarget target { get; set; }
    public UnityEditor.Build.Player.TypeDB typeDB { get; set; }

}

}
