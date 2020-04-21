using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Cubemap : Texture
{
    static public Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex);

    public int desiredMipmapLevel { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }
    public int loadedMipmapLevel { get; }
    public int loadingMipmapLevel { get; }
    public int requestedMipmapLevel { get; set; }
    public bool streamingMipmaps { get; }
    public int streamingMipmapsPriority { get; }

    public Cubemap(int width, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Cubemap(int width, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Cubemap(int width, TextureFormat format, int mipCount);
    public Cubemap(int width, TextureFormat textureFormat, bool mipChain);
    public Cubemap(int width, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags, int mipCount);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void ClearRequestedMipmapLevel();
    public Color GetPixel(CubemapFace face, int x, int y);
    public Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face);
    public Color[] GetPixels(CubemapFace face);
    public Color[] GetPixels(CubemapFace face, int miplevel);
    public bool IsRequestedMipmapLevelLoaded();
    public void SetPixel(CubemapFace face, int x, int y, Color color);
    public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0);
    public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0);
    public void SetPixels(Color[] colors, CubemapFace face);
    public void SetPixels(Color[] colors, CubemapFace face, int miplevel);
    public void SmoothEdges();
    public void SmoothEdges(int smoothRegionWidthInPixels);
    public void UpdateExternalTexture(IntPtr nativeTexture);

}

}
