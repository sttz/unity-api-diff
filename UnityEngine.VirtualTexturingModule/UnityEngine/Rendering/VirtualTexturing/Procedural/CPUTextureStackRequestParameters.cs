using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing.Procedural
{

public struct CPUTextureStackRequestParameters
{
    public int height;
    public int level;
    public int numLayers;
    public int width;
    public int x;
    public int y;

    public void CopyPixelDataToLayer<T>(Unity.Collections.NativeArray<T> colorData, int layerIdx, Experimental.Rendering.GraphicsFormat format);
    public Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters GetLayer(int index);

}

}
