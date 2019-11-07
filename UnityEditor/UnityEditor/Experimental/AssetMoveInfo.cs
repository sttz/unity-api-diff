using System;
using UnityEngine;

namespace UnityEditor.Experimental
{

public struct AssetMoveInfo : IEquatable<UnityEditor.Experimental.AssetMoveInfo>
{
    public string destinationAssetPath { get; }
    public string sourceAssetPath { get; }

    public AssetMoveInfo(string sourceAssetPath, string destinationAssetPath);

    public bool Equals(UnityEditor.Experimental.AssetMoveInfo other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
