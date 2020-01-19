using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct ProceduralTextureStackCreationParams
{
    static public int MaxNumLayers = 4;
    static public int MaxRequestsPerFrameSupported = 4095;

    public uint height;
    public Experimental.Rendering.GraphicsFormat[] layers;
    public uint maxRequestsPerFrame;
    public uint tilesize;
    public uint width;

}

}
