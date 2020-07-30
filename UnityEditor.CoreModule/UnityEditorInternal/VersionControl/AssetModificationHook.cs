using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{

public class AssetModificationHook
{
    static public void FileModeChanged(string[] assets, UnityEditor.VersionControl.FileMode mode);
    static public bool IsOpenForEdit(string assetPath, out string message, UnityEditor.StatusQueryOptions statusOptions);
    static public UnityEditor.AssetDeleteResult OnWillDeleteAsset(string assetPath, UnityEditor.RemoveAssetOptions option);
    static public void OnWillDeleteAssets(string[] assetPaths, UnityEditor.AssetDeleteResult[] deletionResults, UnityEditor.RemoveAssetOptions option);
    static public UnityEditor.AssetMoveResult OnWillMoveAsset(string from, string to);

    public AssetModificationHook();

}

}