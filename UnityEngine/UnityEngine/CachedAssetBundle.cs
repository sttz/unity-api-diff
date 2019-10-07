using System;
using UnityEngine;

namespace UnityEngine
{

public struct CachedAssetBundle
{
    public Hash128 hash { get; set; }
    public string name { get; set; }

    public CachedAssetBundle(string name, Hash128 hash);

}

}
