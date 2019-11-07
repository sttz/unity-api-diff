using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class AssetStoreAsset
{
    public string className;
    public string displayName;
    public string dynamicPreviewURL;
    public int id;
    public string name;
    public int packageID;
    public Texture2D previewImage;
    public string price;
    public string staticPreviewURL;

    public bool HasLivePreview { get; }
    public Object Preview { get; }

    public AssetStoreAsset();

    public void Dispose();

}

}
