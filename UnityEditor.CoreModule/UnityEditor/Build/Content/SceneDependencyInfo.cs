using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct SceneDependencyInfo
{
    public UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<Type> includedTypes { get; }
    public string processedScene { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ObjectIdentifier> referencedObjects { get; }
    public string scene { get; }

}

}