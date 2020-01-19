using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class CubemapArray : Texture
{
    public int cubemapCount { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }

    public CubemapArray(int width, int cubemapCount, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain);
    public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public Color[] GetPixels(CubemapFace face, int arrayElement);
    public Color[] GetPixels(CubemapFace face, int arrayElement, int miplevel);
    public Color32[] GetPixels32(CubemapFace face, int arrayElement);
    public Color32[] GetPixels32(CubemapFace face, int arrayElement, int miplevel);
    public void SetPixels(Color[] colors, CubemapFace face, int arrayElement);
    public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel);
    public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement);
    public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement, int miplevel);

}

}