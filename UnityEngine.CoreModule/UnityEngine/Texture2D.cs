using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Texture2D : Texture
{
    static public Texture2D blackTexture { get; }
    static public Texture2D grayTexture { get; }
    static public Texture2D linearGrayTexture { get; }
    static public Texture2D normalTexture { get; }
    static public Texture2D redTexture { get; }
    static public Texture2D whiteTexture { get; }

    static public Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex);
    static public bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results);

    public bool alphaIsTransparency { get; set; }
    public int calculatedMipmapLevel { get; }
    public int desiredMipmapLevel { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }
    public int loadedMipmapLevel { get; }
    public int loadingMipmapLevel { get; }
    public int minimumMipmapLevel { get; set; }
    public int requestedMipmapLevel { get; set; }
    public bool streamingMipmaps { get; }
    public int streamingMipmapsPriority { get; }
    public bool vtOnly { get; }

    public Texture2D(int width, int height);
    public Texture2D(int width, int height, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2D(int width, int height, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain);
    public Texture2D(int width, int height, Experimental.Rendering.GraphicsFormat format, int mipCount, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear);
    public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear);

    public void Apply();
    public void Apply(bool updateMipmaps);
    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void ClearMinimumMipmapLevel();
    public void ClearRequestedMipmapLevel();
    public void Compress(bool highQuality);
    public Color GetPixel(int x, int y);
    public Color GetPixel(int x, int y, int mipLevel);
    public Color GetPixelBilinear(float u, float v);
    public Color GetPixelBilinear(float u, float v, int mipLevel);
    public Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
    public Color[] GetPixels();
    public Color[] GetPixels(int miplevel);
    public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
    public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
    public Color32[] GetPixels32();
    public Color32[] GetPixels32(int miplevel);
    public byte[] GetRawTextureData();
    public Unity.Collections.NativeArray<T> GetRawTextureData<T>();
    public bool IsRequestedMipmapLevelLoaded();
    public void LoadRawTextureData(byte[] data);
    public void LoadRawTextureData(IntPtr data, int size);
    public void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data);
    public Rect[] PackTextures(Texture2D[] textures, int padding);
    public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize);
    public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
    public void ReadPixels(Rect source, int destX, int destY);
    public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps);
    public bool Resize(int width, int height);
    public bool Resize(int width, int height, Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
    public bool Resize(int width, int height, TextureFormat format, bool hasMipMap);
    public void SetPixel(int x, int y, Color color);
    public void SetPixel(int x, int y, Color color, int mipLevel);
    public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0);
    public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0);
    public void SetPixels(Color[] colors);
    public void SetPixels(Color[] colors, int miplevel);
    public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors);
    public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel);
    public void SetPixels32(Color32[] colors);
    public void SetPixels32(Color32[] colors, int miplevel);
    public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors);
    public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel);
    public void UpdateExternalTexture(IntPtr nativeTex);

    public enum EXRFlags
    {
        None = 0,
        OutputAsFloat = 1,
        CompressZIP = 2,
        CompressRLE = 4,
        CompressPIZ = 8,
    }

}

}
