using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct SceneDependencyInfo
{
    public UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage { get; }
    public string processedScene { get; }
    public System.Collections.ObjectModel.ReadOnlyCollection<UnityEditor.Build.Content.ObjectIdentifier> referencedObjects { get; }
    public string scene { get; }

}

}
