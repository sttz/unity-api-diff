using System;
using UnityEngine;

namespace UnityEditor
{

public enum BuildAssetBundleOptions
{
    None = 0,
    UncompressedAssetBundle = 1,
    CollectDependencies = 2,
    CompleteAssets = 4,
    DisableWriteTypeTree = 8,
    DeterministicAssetBundle = 16,
    ForceRebuildAssetBundle = 32,
    IgnoreTypeTreeChanges = 64,
    AppendHashToAssetBundleName = 128,
    ChunkBasedCompression = 256,
    StrictMode = 512,
    DryRunBuild = 1024,
    DisableLoadAssetByFileName = 4096,
    DisableLoadAssetByFileNameWithExtension = 8192,
}

}
