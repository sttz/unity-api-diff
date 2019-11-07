using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct WriteSceneParameters
{
    public UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage;
    public UnityEditor.Build.Content.PreloadInfo preloadInfo;
    public UnityEditor.Build.Content.BuildReferenceMap referenceMap;
    public UnityEditor.Build.Content.SceneBundleInfo sceneBundleInfo;
    public string scenePath;
    public UnityEditor.Build.Content.BuildSettings settings;
    public UnityEditor.Build.Content.BuildUsageTagSet usageSet;
    public UnityEditor.Build.Content.WriteCommand writeCommand;

}

}
