using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct RenderTargetBinding
{
    public Rendering.RenderBufferLoadAction[] colorLoadActions { get; set; }
    public Rendering.RenderTargetIdentifier[] colorRenderTargets { get; set; }
    public Rendering.RenderBufferStoreAction[] colorStoreActions { get; set; }
    public Rendering.RenderBufferLoadAction depthLoadAction { get; set; }
    public Rendering.RenderTargetIdentifier depthRenderTarget { get; set; }
    public Rendering.RenderBufferStoreAction depthStoreAction { get; set; }

    public RenderTargetBinding(Rendering.RenderTargetIdentifier[] colorRenderTargets, Rendering.RenderBufferLoadAction[] colorLoadActions, Rendering.RenderBufferStoreAction[] colorStoreActions, Rendering.RenderTargetIdentifier depthRenderTarget, Rendering.RenderBufferLoadAction depthLoadAction, Rendering.RenderBufferStoreAction depthStoreAction);
    public RenderTargetBinding(Rendering.RenderTargetIdentifier colorRenderTarget, Rendering.RenderBufferLoadAction colorLoadAction, Rendering.RenderBufferStoreAction colorStoreAction, Rendering.RenderTargetIdentifier depthRenderTarget, Rendering.RenderBufferLoadAction depthLoadAction, Rendering.RenderBufferStoreAction depthStoreAction);
    public RenderTargetBinding(RenderTargetSetup setup);

}

}
