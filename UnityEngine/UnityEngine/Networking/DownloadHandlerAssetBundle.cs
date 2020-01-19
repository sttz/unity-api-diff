using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public sealed class DownloadHandlerAssetBundle : Networking.DownloadHandler
{
    static public AssetBundle GetContent(Networking.UnityWebRequest www);

    public AssetBundle assetBundle { get; }

    public DownloadHandlerAssetBundle(string url, uint crc);
    public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc);
    public DownloadHandlerAssetBundle(string url, Hash128 hash, uint crc);
    public DownloadHandlerAssetBundle(string url, uint version, uint crc);
    public DownloadHandlerAssetBundle(string url, string name, Hash128 hash, uint crc);

    protected byte[] GetData();
    protected string GetText();

}

}
