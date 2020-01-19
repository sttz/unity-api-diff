using System;
using System.Collections;
using System.Collections.Generic;
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
