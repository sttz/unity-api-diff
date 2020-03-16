using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing.Procedural
{

public struct CreationParameters
{
    static public int MaxNumLayers = 4;
    static public int MaxRequestsPerFrameSupported = 4095;

    public int height;
    public Experimental.Rendering.GraphicsFormat[] layers;
    public int maxActiveRequests;
    public int tilesize;
    public int width;

}

}
