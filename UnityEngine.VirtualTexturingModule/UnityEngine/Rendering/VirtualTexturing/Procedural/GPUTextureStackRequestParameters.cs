using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing.Procedural
{

public struct GPUTextureStackRequestParameters
{
    public int height;
    public int level;
    public int numLayers;
    public int width;
    public int x;
    public int y;

    public Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters GetLayer(int index);

}

}
