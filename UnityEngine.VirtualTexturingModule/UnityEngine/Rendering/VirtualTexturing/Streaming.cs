using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public static class Streaming
{
    static public void GetTextureStackSize(Material mat, int stackNameId, out int width, out int height);
    static public void RequestRegion(Material mat, int stackNameId, Rect r, int mipMap, int numMips);
    static public void SetCPUCacheSize(int sizeInMegabytes);
    static public void SetGPUCacheSettings(Rendering.VirtualTexturing.GPUCacheSetting[] cacheSettings);

}

}
