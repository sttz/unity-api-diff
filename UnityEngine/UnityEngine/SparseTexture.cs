using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class SparseTexture : Texture
{
    public bool isCreated { get; }
    public int tileHeight { get; }
    public int tileWidth { get; }

    public SparseTexture(int width, int height, Experimental.Rendering.GraphicsFormat format, int mipCount);
    public SparseTexture(int width, int height, TextureFormat format, int mipCount);
    public SparseTexture(int width, int height, TextureFormat format, int mipCount, bool linear);

    public void UnloadTile(int tileX, int tileY, int miplevel);
    public void UpdateTile(int tileX, int tileY, int miplevel, Color32[] data);
    public void UpdateTileRaw(int tileX, int tileY, int miplevel, byte[] data);

}

}
