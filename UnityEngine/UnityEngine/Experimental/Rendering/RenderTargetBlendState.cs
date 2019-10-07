using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct RenderTargetBlendState
{
    static public Experimental.Rendering.RenderTargetBlendState Default { get; }

    public Rendering.BlendOp alphaBlendOperation { get; set; }
    public Rendering.BlendOp colorBlendOperation { get; set; }
    public Rendering.BlendMode destinationAlphaBlendMode { get; set; }
    public Rendering.BlendMode destinationColorBlendMode { get; set; }
    public Rendering.BlendMode sourceAlphaBlendMode { get; set; }
    public Rendering.BlendMode sourceColorBlendMode { get; set; }
    public Rendering.ColorWriteMask writeMask { get; set; }

    public RenderTargetBlendState(Rendering.ColorWriteMask writeMask = 15, Rendering.BlendMode sourceColorBlendMode = 1, Rendering.BlendMode destinationColorBlendMode = 0, Rendering.BlendMode sourceAlphaBlendMode = 1, Rendering.BlendMode destinationAlphaBlendMode = 0, Rendering.BlendOp colorBlendOperation = 0, Rendering.BlendOp alphaBlendOperation = 0);

}

}
