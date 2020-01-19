using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct RenderStateBlock
{
    public Experimental.Rendering.BlendState blendState { get; set; }
    public Experimental.Rendering.DepthState depthState { get; set; }
    public Experimental.Rendering.RenderStateMask mask { get; set; }
    public Experimental.Rendering.RasterState rasterState { get; set; }
    public int stencilReference { get; set; }
    public Experimental.Rendering.StencilState stencilState { get; set; }

    public RenderStateBlock(Experimental.Rendering.RenderStateMask mask);

}

}
