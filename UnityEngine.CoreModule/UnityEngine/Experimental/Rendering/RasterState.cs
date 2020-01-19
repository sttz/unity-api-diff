using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct RasterState
{
    static public Experimental.Rendering.RasterState Default;

    public Rendering.CullMode cullingMode { get; set; }
    public bool depthClip { get; set; }
    public float offsetFactor { get; set; }
    public int offsetUnits { get; set; }

    public RasterState(Rendering.CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = true);

}

}
