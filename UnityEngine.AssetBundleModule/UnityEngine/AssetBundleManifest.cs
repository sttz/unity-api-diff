using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class AssetBundleManifest : Object
{
    public string[] GetAllAssetBundles();
    public string[] GetAllAssetBundlesWithVariant();
    public string[] GetAllDependencies(string assetBundleName);
    public Hash128 GetAssetBundleHash(string assetBundleName);
    public string[] GetDirectDependencies(string assetBundleName);

}

}
