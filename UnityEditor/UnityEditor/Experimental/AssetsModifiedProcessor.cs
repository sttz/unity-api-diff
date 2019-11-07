using System;
using UnityEngine;

namespace UnityEditor.Experimental
{

public abstract class AssetsModifiedProcessor
{
    public System.Collections.Generic.HashSet<string> assetsReportedChanged { get; set; }

    protected AssetsModifiedProcessor();

    protected void OnAssetsModified(string[] changedAssets, string[] addedAssets, string[] deletedAssets, UnityEditor.Experimental.AssetMoveInfo[] movedAssets);
    protected void ReportAssetChanged(string assetChanged);

}

}
