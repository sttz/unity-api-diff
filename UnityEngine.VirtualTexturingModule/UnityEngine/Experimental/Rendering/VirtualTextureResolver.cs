using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class VirtualTextureResolver : IDisposable
{
    public uint CurrentHeight { get; private set; }
    public uint CurrentWidth { get; private set; }

    public VirtualTextureResolver();

    public void Dispose();
    protected void Dispose(bool disposing);
    public void Init(uint width, uint height);
    public void Process(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rt);
    public void Process(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rt, uint x, uint width, uint y, uint height, uint mip, uint slice);

}

}
