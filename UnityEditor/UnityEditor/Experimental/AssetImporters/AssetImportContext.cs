using System;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class AssetImportContext
{
    public string assetPath { get; internal set; }
    public Object mainObject { get; }
    public UnityEditor.BuildTarget selectedBuildTarget { get; }

    public void AddObjectToAsset(string identifier, Object obj);
    public void AddObjectToAsset(string identifier, Object obj, Texture2D thumbnail);
    public void DependsOnCustomDependency(string dependency);
    public void DependsOnSourceAsset(string path);
    public void GetObjects(System.Collections.Generic.List<Object> objects);
    public string GetResultPath(string extension);
    public void LogImportError(string msg, Object obj = null);
    public void LogImportWarning(string msg, Object obj = null);
    public void SetMainObject(Object obj);

}

}
