using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public abstract class ScriptedImporter : UnityEditor.AssetImporter
{
    protected ScriptedImporter();

    public void OnImportAsset(UnityEditor.AssetImporters.AssetImportContext ctx);
    public bool SupportsRemappedAssetType(Type type);

}

}
