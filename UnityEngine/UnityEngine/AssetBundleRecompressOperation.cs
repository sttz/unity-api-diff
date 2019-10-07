using System;
using UnityEngine;

namespace UnityEngine
{

public class AssetBundleRecompressOperation : AsyncOperation
{
    public string humanReadableResult { get; }
    public string inputPath { get; }
    public string outputPath { get; }
    public AssetBundleLoadResult result { get; }
    public bool success { get; }

    public AssetBundleRecompressOperation();

}

}
