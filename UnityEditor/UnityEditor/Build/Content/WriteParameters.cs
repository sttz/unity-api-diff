using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct WriteParameters
{
    public UnityEditor.Build.Content.AssetBundleInfo bundleInfo;
    public UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage;
    public UnityEditor.Build.Content.BuildReferenceMap referenceMap;
    public UnityEditor.Build.Content.BuildSettings settings;
    public UnityEditor.Build.Content.BuildUsageTagSet usageSet;
    public UnityEditor.Build.Content.WriteCommand writeCommand;

}

}
