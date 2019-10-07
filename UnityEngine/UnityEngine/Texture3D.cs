using System;
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

    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void Apply(bool updateMipmaps);
    public void Apply();
    public Color[] GetPixels(int miplevel);
    public Color[] GetPixels();
    public Color32[] GetPixels32(int miplevel);
    public Color32[] GetPixels32();
    public void SetPixels(Color[] colors, int miplevel);
    public void SetPixels(Color[] colors);
    public void SetPixels32(Color32[] colors, int miplevel);
    public void SetPixels32(Color32[] colors);

}

}
