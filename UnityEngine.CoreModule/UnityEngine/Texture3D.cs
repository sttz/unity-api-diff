using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Texture3D : Texture
{
    public int depth { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }

    public Texture3D(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public Color[] GetPixels();
    public Color[] GetPixels(int miplevel);
    public Color32[] GetPixels32();
    public Color32[] GetPixels32(int miplevel);
    public void SetPixels(Color[] colors);
    public void SetPixels(Color[] colors, int miplevel);
    public void SetPixels32(Color32[] colors);
    public void SetPixels32(Color32[] colors, int miplevel);

}

}
