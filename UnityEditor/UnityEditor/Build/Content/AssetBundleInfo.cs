using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public class AssetBundleInfo
{
    public List<UnityEditor.Build.Content.AssetLoadInfo> bundleAssets { get; set; }
    public string bundleName { get; set; }

    public AssetBundleInfo();

}

}
