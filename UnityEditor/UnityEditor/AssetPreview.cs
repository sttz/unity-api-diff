using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class AssetPreview
{
    static public Texture2D GetAssetPreview(Object asset);
    static public Texture2D GetMiniThumbnail(Object obj);
    static public Texture2D GetMiniTypeThumbnail(Type type);
    static public bool IsLoadingAssetPreview(int instanceID);
    static public bool IsLoadingAssetPreviews();
    static public void SetPreviewTextureCacheSize(int size);

    public AssetPreview();

}

}
