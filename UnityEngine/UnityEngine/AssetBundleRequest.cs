using System;
using UnityEngine;

namespace UnityEngine
{

public class AssetBundleRequest : AsyncOperation
{
    public Object[] allAssets { get; }
    public Object asset { get; }

    public AssetBundleRequest();

}

}
