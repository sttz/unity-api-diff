using System;
using UnityEngine;

namespace UnityEngine
{

public struct RenderTextureDescriptor
{
    public bool autoGenerateMips { get; set; }
    public bool bindMS { get; set; }
    public RenderTextureFormat colorFormat { get; set; }
    public int depthBufferBits { get; set; }
    public Rendering.TextureDimension dimension { get; set; }
    public bool enableRandomWrite { get; set; }
    public RenderTextureCreationFlags flags { get; }
    public Experimental.Rendering.GraphicsFormat graphicsFormat { get; set; }
    public int height { get; set; }
    public RenderTextureMemoryless memoryless { get; set; }
    public int mipCount { get; set; }
    public int msaaSamples { get; set; }
    public Rendering.ShadowSamplingMode shadowSamplingMode { get; set; }
    public bool sRGB { get; set; }
    public Experimental.Rendering.GraphicsFormat stencilFormat { get; set; }
    public bool useDynamicScale { get; set; }
    public bool useMipMap { get; set; }
    public int volumeDepth { get; set; }
    public VRTextureUsage vrUsage { get; set; }
    public int width { get; set; }

    public RenderTextureDescriptor(int width, int height);
    public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat);
    public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits);
    public RenderTextureDescriptor(int width, int height, Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
    public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
    public RenderTextureDescriptor(int width, int height, Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);

}

}
