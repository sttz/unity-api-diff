using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct RenderStateBlock : IEquatable<Rendering.RenderStateBlock>
{
    public Rendering.BlendState blendState { get; set; }
    public Rendering.DepthState depthState { get; set; }
    public Rendering.RenderStateMask mask { get; set; }
    public Rendering.RasterState rasterState { get; set; }
    public int stencilReference { get; set; }
    public Rendering.StencilState stencilState { get; set; }

    public RenderStateBlock(Rendering.RenderStateMask mask);

    public bool Equals(Rendering.RenderStateBlock other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
