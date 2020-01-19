using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public abstract class AssetsModifiedProcessor
{
    public HashSet<string> assetsReportedChanged { get; set; }

    protected AssetsModifiedProcessor();

    protected void OnAssetsModified(string[] changedAssets, string[] addedAssets, string[] deletedAssets, UnityEditor.Experimental.AssetMoveInfo[] movedAssets);
    protected void ReportAssetChanged(string assetChanged);

}

}
