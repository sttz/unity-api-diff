using System;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public struct ScriptCompilationResult
{
    public System.Collections.ObjectModel.ReadOnlyCollection<string> assemblies { get; }
    public UnityEditor.Build.Player.TypeDB typeDB { get; }

}

}
