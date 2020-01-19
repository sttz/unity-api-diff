using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct BlendState
{
    static public Experimental.Rendering.BlendState Default { get; }

    public bool alphaToMask { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState0 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState1 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState2 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState3 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState4 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState5 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState6 { get; set; }
    public Experimental.Rendering.RenderTargetBlendState blendState7 { get; set; }
    public bool separateMRTBlendStates { get; set; }

    public BlendState(bool separateMRTBlend = false, bool alphaToMask = false);

}

}
