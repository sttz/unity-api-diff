using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AssetImporter : Object
{
    static public UnityEditor.AssetImporter GetAtPath(string path);

    public string assetBundleName { get; set; }
    public string assetBundleVariant { get; set; }
    public string assetPath { get; }
    public ulong assetTimeStamp { get; }
    public bool importSettingsMissing { get; }
    public string userData { get; set; }

    public AssetImporter();

    public void AddRemap(SourceAssetIdentifier identifier, Object externalObject);
    public Dictionary<SourceAssetIdentifier, Object> GetExternalObjectMap();
    public bool RemoveRemap(SourceAssetIdentifier identifier);
    public void SaveAndReimport();
    public void SetAssetBundleNameAndVariant(string assetBundleName, string assetBundleVariant);
    public bool SupportsRemappedAssetType(Type type);

    public struct SourceAssetIdentifier
    {
        public string name;
        public Type type;

        public SourceAssetIdentifier(Object asset);
        public SourceAssetIdentifier(Type type, string name);

    }

}

}
