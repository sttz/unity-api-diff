using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public class Resolver : IDisposable
{
    public int CurrentHeight { get; private set; }
    public int CurrentWidth { get; private set; }

    public Resolver();

    public void Dispose();
    protected void Dispose(bool disposing);
    public void Process(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rt);
    public void Process(Rendering.CommandBuffer cmd, Rendering.RenderTargetIdentifier rt, int x, int width, int y, int height, int mip, int slice);
    public void UpdateSize(int width, int height);

}

}
