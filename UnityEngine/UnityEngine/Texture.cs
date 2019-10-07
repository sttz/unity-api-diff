using System;
using UnityEngine;

namespace UnityEngine
{

public class Texture : Object
{
    static public AnisotropicFiltering anisotropicFiltering { get; set; }
    static public ulong currentTextureMemory { get; }
    static public ulong desiredTextureMemory { get; }
    static public int masterTextureLimit { get; set; }
    static public ulong nonStreamingTextureCount { get; }
    static public ulong nonStreamingTextureMemory { get; }
    static public ulong streamingMipmapUploadCount { get; }
    static public ulong streamingRendererCount { get; }
    static public ulong streamingTextureCount { get; }
    static public bool streamingTextureDiscardUnusedMips { get; set; }
    static public bool streamingTextureForceLoadAll { get; set; }
    static public ulong streamingTextureLoadingCount { get; }
    static public ulong streamingTexturePendingLoadCount { get; }
    static public ulong targetTextureMemory { get; }
    static public ulong totalTextureMemory { get; }

    static public void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);
    static public void SetStreamingTextureMaterialDebugProperties();

    public int anisoLevel { get; set; }
    public Rendering.TextureDimension dimension { get; set; }
    public FilterMode filterMode { get; set; }
    public int height { get; set; }
    public Hash128 imageContentsHash { get; set; }
    public bool isReadable { get; }
    public float mipMapBias { get; set; }
    public Vector2 texelSize { get; }
    public uint updateCount { get; }
    public int width { get; set; }
    public TextureWrapMode wrapMode { get; set; }
    public TextureWrapMode wrapModeU { get; set; }
    public TextureWrapMode wrapModeV { get; set; }
    public TextureWrapMode wrapModeW { get; set; }

    protected Texture();

    public int GetNativeTextureID();
    public IntPtr GetNativeTexturePtr();
    public void IncrementUpdateCount();

}

}
