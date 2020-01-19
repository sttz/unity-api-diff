using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.VersionControl
{

public class AssetList : List<UnityEditor.VersionControl.Asset>
{
    public AssetList();
    public AssetList(UnityEditor.VersionControl.AssetList src);

    public UnityEditor.VersionControl.AssetList Filter(bool includeFolder, States[] states);
    public UnityEditor.VersionControl.AssetList FilterChildren();
    public int FilterCount(bool includeFolder, States[] states);

}

}
