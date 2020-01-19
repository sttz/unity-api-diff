using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public sealed class AssetStoreToolUtils
{
    static public bool BuildAssetStoreAssetBundle(Object targetObject, string targetPath);
    static public bool PreviewAssetStoreAssetBundleInInspector(AssetBundle bundle, UnityEditor.AssetStoreAsset info);
    static public void UpdatePreloadingInternal();

    public AssetStoreToolUtils();

}

}
