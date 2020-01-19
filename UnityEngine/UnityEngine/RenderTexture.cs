using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class RenderTexture : Texture
{
    static public RenderTexture active { get; set; }
    static public bool enabled { get; set; }

    static public RenderTexture GetTemporary(RenderTextureDescriptor desc);
    static public RenderTexture GetTemporary(int width, int height);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, Experimental.Rendering.GraphicsFormat format);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, Experimental.Rendering.GraphicsFormat format, int antiAliasing);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage);
    static public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale);
    static public void ReleaseTemporary(RenderTexture temp);
    static public bool SupportsStencil(RenderTexture rt);

    public int antiAliasing { get; set; }
    public bool autoGenerateMips { get; set; }
    public bool bindTextureMS { get; set; }
    public RenderBuffer colorBuffer { get; }
    public int depth { get; set; }
    public RenderBuffer depthBuffer { get; }
    public RenderTextureDescriptor descriptor { get; set; }
    public Rendering.TextureDimension dimension { get; set; }
    public bool enableRandomWrite { get; set; }
    public RenderTextureFormat format { get; set; }
    public bool generateMips { get; set; }
    public Experimental.Rendering.GraphicsFormat graphicsFormat { get; set; }
    public int height { get; set; }
    public bool isCubemap { get; set; }
    public bool isPowerOfTwo { get; set; }
    public bool isVolume { get; set; }
    public RenderTextureMemoryless memorylessMode { get; set; }
    public bool sRGB { get; }
    public bool useDynamicScale { get; set; }
    public bool useMipMap { get; set; }
    public int volumeDepth { get; set; }
    public VRTextureUsage vrUsage { get; set; }
    public int width { get; set; }

    public RenderTexture(RenderTextureDescriptor desc);
    public RenderTexture(RenderTexture textureToCopy);
    public RenderTexture(int width, int height, int depth);
    public RenderTexture(int width, int height, int depth, Experimental.Rendering.DefaultFormat format);
    public RenderTexture(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format);
    public RenderTexture(int width, int height, int depth, RenderTextureFormat format);
    public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite);

    public void ConvertToEquirect(RenderTexture equirect, MonoOrStereoscopicEye eye = 2);
    public bool Create();
    public void DiscardContents();
    public void DiscardContents(bool discardColor, bool discardDepth);
    public void GenerateMips();
    public IntPtr GetNativeDepthBufferPtr();
    public Vector2 GetTexelOffset();
    public bool IsCreated();
    public void MarkRestoreExpected();
    public void Release();
    public void ResolveAntiAliasedSurface();
    public void ResolveAntiAliasedSurface(RenderTexture target);
    public void SetBorderColor(Color color);
    public void SetGlobalShaderProperty(string propertyName);

}

}
