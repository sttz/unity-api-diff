using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public static class UnityWebRequestAssetBundle
{
    static public Networking.UnityWebRequest GetAssetBundle(string uri);
    static public Networking.UnityWebRequest GetAssetBundle(Uri uri);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(Uri uri, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc = 0);
    static public Networking.UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc = 0);
    static public Networking.UnityWebRequest GetAssetBundle(Uri uri, Hash128 hash, uint crc = 0);
    static public Networking.UnityWebRequest GetAssetBundle(string uri, uint version, uint crc);
    static public Networking.UnityWebRequest GetAssetBundle(Uri uri, uint version, uint crc);

}

}
