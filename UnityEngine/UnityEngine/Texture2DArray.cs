using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Texture2DArray : Texture
{
    static public int allSlices { get; }

    public int depth { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }

    public Texture2DArray(int width, int height, int depth, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2DArray(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2DArray(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags, int mipCount);
    public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear);
    public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear);
    public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain);

    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void Apply(bool updateMipmaps);
    public void Apply();
    public Unity.Collections.NativeArray<T> GetPixelData(int mipLevel, int element);
    public Color[] GetPixels(int arrayElement, int miplevel);
    public Color[] GetPixels(int arrayElement);
    public Color32[] GetPixels32(int arrayElement, int miplevel);
    public Color32[] GetPixels32(int arrayElement);
    public void SetPixelData(T[] data, int mipLevel, int element, int sourceDataStartIndex = 0);
    public void SetPixelData(Unity.Collections.NativeArray<T> data, int mipLevel, int element, int sourceDataStartIndex = 0);
    public void SetPixels(Color[] colors, int arrayElement, int miplevel);
    public void SetPixels(Color[] colors, int arrayElement);
    public void SetPixels32(Color32[] colors, int arrayElement, int miplevel);
    public void SetPixels32(Color32[] colors, int arrayElement);

}

}
