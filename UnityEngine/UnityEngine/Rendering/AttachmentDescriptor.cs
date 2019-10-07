using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct AttachmentDescriptor : IEquatable<Rendering.AttachmentDescriptor>
{
    public Color clearColor { get; set; }
    public float clearDepth { get; set; }
    public uint clearStencil { get; set; }
    public RenderTextureFormat format { get; set; }
    public Experimental.Rendering.GraphicsFormat graphicsFormat { get; set; }
    public Rendering.RenderBufferLoadAction loadAction { get; set; }
    public Rendering.RenderTargetIdentifier loadStoreTarget { get; set; }
    public Rendering.RenderTargetIdentifier resolveTarget { get; set; }
    public Rendering.RenderBufferStoreAction storeAction { get; set; }

    public AttachmentDescriptor(Experimental.Rendering.GraphicsFormat format);
    public AttachmentDescriptor(RenderTextureFormat format);
    public AttachmentDescriptor(RenderTextureFormat format, Rendering.RenderTargetIdentifier target, bool loadExistingContents = false, bool storeResults = false, bool resolve = false);

    public void ConfigureClear(Color clearColor, float clearDepth = 1, uint clearStencil = 0);
    public void ConfigureResolveTarget(Rendering.RenderTargetIdentifier target);
    public void ConfigureTarget(Rendering.RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
    public bool Equals(Rendering.AttachmentDescriptor other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
