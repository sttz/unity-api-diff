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

    public CubemapArray(int width, int cubemapCount, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public CubemapArray(int width, int cubemapCount, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain);
    public CubemapArray(int width, int cubemapCount, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags, int mipCount);
    public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear);
    public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element);
    public Color[] GetPixels(CubemapFace face, int arrayElement);
    public Color[] GetPixels(CubemapFace face, int arrayElement, int miplevel);
    public Color32[] GetPixels32(CubemapFace face, int arrayElement);
    public Color32[] GetPixels32(CubemapFace face, int arrayElement, int miplevel);
    public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, int element, int sourceDataStartIndex = 0);
    public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, int element, int sourceDataStartIndex = 0);
    public void SetPixels(Color[] colors, CubemapFace face, int arrayElement);
    public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel);
    public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement);
    public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement, int miplevel);

}

}
