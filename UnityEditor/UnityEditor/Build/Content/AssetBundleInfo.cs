using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class AssetBundleInfo
{
    public System.Collections.Generic.List<UnityEditor.Build.Content.AssetLoadInfo> bundleAssets { get; set; }
    public string bundleName { get; set; }

    public AssetBundleInfo();

}

}
