using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct ProceduralTextureStackRequest
{
    public int height;
    public int level;
    public int numLayers;
    public int width;
    public int x;
    public int y;

    public Experimental.Rendering.ProceduralTextureStackRequestLayer GetLayer(int index);

}

}
