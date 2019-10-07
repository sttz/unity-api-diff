using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Cubemap : Texture
{
    static public Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex);

    public TextureFormat format { get; }
    public bool isReadable { get; }
    public int mipmapCount { get; }

    public Cubemap(int width, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Cubemap(int width, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Cubemap(int width, TextureFormat textureFormat, bool mipChain);

    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void Apply(bool updateMipmaps);
    public void Apply();
    public Color GetPixel(CubemapFace face, int x, int y);
    public Color[] GetPixels(CubemapFace face, int miplevel);
    public Color[] GetPixels(CubemapFace face);
    public void SetPixel(CubemapFace face, int x, int y, Color color);
    public void SetPixels(Color[] colors, CubemapFace face, int miplevel);
    public void SetPixels(Color[] colors, CubemapFace face);
    public void SmoothEdges(int smoothRegionWidthInPixels);
    public void SmoothEdges();
    public void UpdateExternalTexture(IntPtr nativeTexture);

}

}
