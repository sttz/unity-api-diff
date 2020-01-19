using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Texture2DArray : Texture
{
    public int depth { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }

    public Texture2DArray(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain);
    public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public Color[] GetPixels(int arrayElement);
    public Color[] GetPixels(int arrayElement, int miplevel);
    public Color32[] GetPixels32(int arrayElement);
    public Color32[] GetPixels32(int arrayElement, int miplevel);
    public void SetPixels(Color[] colors, int arrayElement);
    public void SetPixels(Color[] colors, int arrayElement, int miplevel);
    public void SetPixels32(Color32[] colors, int arrayElement);
    public void SetPixels32(Color32[] colors, int arrayElement, int miplevel);

}

}
