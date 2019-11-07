using System;
using UnityEngine;

namespace UnityEditor.Compilation
{

public struct AssemblyDefinitionPlatform
{
    public UnityEditor.BuildTarget BuildTarget { get; private set; }
    public string DisplayName { get; private set; }
    public string Name { get; private set; }

}

}
