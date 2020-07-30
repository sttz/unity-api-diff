using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AssetPostprocessor
{
    public UnityEditor.AssetImporter assetImporter { get; }
    public string assetPath { get; set; }
    public UnityEditor.AssetImporters.AssetImportContext context { get; internal set; }
    public Texture2D preview { get; set; }

    public AssetPostprocessor();

    public int GetPostprocessOrder();
    public uint GetVersion();
    public void LogError(string warning);
    public void LogError(string warning, Object context);
    public void LogWarning(string warning);
    public void LogWarning(string warning, Object context);

}

}
