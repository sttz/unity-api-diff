using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct BlendState : IEquatable<Rendering.BlendState>
{
    static public Rendering.BlendState defaultValue { get; }

    public bool alphaToMask { get; set; }
    public Rendering.RenderTargetBlendState blendState0 { get; set; }
    public Rendering.RenderTargetBlendState blendState1 { get; set; }
    public Rendering.RenderTargetBlendState blendState2 { get; set; }
    public Rendering.RenderTargetBlendState blendState3 { get; set; }
    public Rendering.RenderTargetBlendState blendState4 { get; set; }
    public Rendering.RenderTargetBlendState blendState5 { get; set; }
    public Rendering.RenderTargetBlendState blendState6 { get; set; }
    public Rendering.RenderTargetBlendState blendState7 { get; set; }
    public bool separateMRTBlendStates { get; set; }

    public BlendState(bool separateMRTBlend = false, bool alphaToMask = false);

    public bool Equals(object obj);
    public bool Equals(Rendering.BlendState other);
    public int GetHashCode();

}

}
