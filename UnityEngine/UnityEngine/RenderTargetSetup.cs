using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct RenderTargetSetup
{
    public RenderBuffer[] color;
    public Rendering.RenderBufferLoadAction[] colorLoad;
    public Rendering.RenderBufferStoreAction[] colorStore;
    public CubemapFace cubemapFace;
    public RenderBuffer depth;
    public Rendering.RenderBufferLoadAction depthLoad;
    public int depthSlice;
    public Rendering.RenderBufferStoreAction depthStore;
    public int mipLevel;

    public RenderTargetSetup(RenderBuffer color, RenderBuffer depth);
    public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth);
    public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel);
    public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel);
    public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face);
    public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face);
    public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face, int depthSlice);
    public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, Rendering.RenderBufferLoadAction[] colorLoad, Rendering.RenderBufferStoreAction[] colorStore, Rendering.RenderBufferLoadAction depthLoad, Rendering.RenderBufferStoreAction depthStore);

}

}
