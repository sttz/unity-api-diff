using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class RenderPassAttachment : Object
{
    static public void Internal_CreateAttachment(Experimental.Rendering.RenderPassAttachment self);

    public Color clearColor { get; private set; }
    public float clearDepth { get; private set; }
    public uint clearStencil { get; private set; }
    public RenderTextureFormat format { get; private set; }
    public Rendering.RenderBufferLoadAction loadAction { get; private set; }
    public Rendering.RenderBufferStoreAction storeAction { get; private set; }

    public RenderPassAttachment(RenderTextureFormat fmt);

    public void BindResolveSurface(Rendering.RenderTargetIdentifier tgt);
    public void BindSurface(Rendering.RenderTargetIdentifier tgt, bool loadExistingContents, bool storeResults);
    public void Clear(Color clearCol, float clearDep = 1, uint clearStenc = 0);

}

}
