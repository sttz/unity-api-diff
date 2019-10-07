using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Texture2D : Texture
{
    static public Texture2D blackTexture { get; }
    static public Texture2D normalTexture { get; }
    static public Texture2D whiteTexture { get; }

    static public Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex);
    static public bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, System.Collections.Generic.List<Rect> results);

    public bool alphaIsTransparency { get; set; }
    public int desiredMipmapLevel { get; }
    public TextureFormat format { get; }
    public bool isReadable { get; }
    public int loadedMipmapLevel { get; }
    public int loadingMipmapLevel { get; }
    public int mipmapCount { get; }
    public int requestedMipmapLevel { get; set; }
    public bool streamingMipmaps { get; }
    public int streamingMipmapsPriority { get; }

    public Texture2D(int width, int height, Experimental.Rendering.DefaultFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2D(int width, int height, Experimental.Rendering.GraphicsFormat format, Experimental.Rendering.TextureCreationFlags flags);
    public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear);
    public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain);
    public Texture2D(int width, int height);

    public void Apply(bool updateMipmaps, bool makeNoLongerReadable);
    public void Apply(bool updateMipmaps);
    public void Apply();
    public void ClearRequestedMipmapLevel();
    public void Compress(bool highQuality);
    public Color GetPixel(int x, int y);
    public Color GetPixel(int x, int y, int mipLevel);
    public Color GetPixelBilinear(float u, float v);
    public Color GetPixelBilinear(float u, float v, int mipLevel);
    public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
    public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
    public Color[] GetPixels(int miplevel);
    public Color[] GetPixels();
    public Color32[] GetPixels32(int miplevel);
    public Color32[] GetPixels32();
    public byte[] GetRawTextureData();
    public Unity.Collections.NativeArray<T> GetRawTextureData();
    public bool IsRequestedMipmapLevelLoaded();
    public void LoadRawTextureData(IntPtr data, int size);
    public void LoadRawTextureData(byte[] data);
    public void LoadRawTextureData(Unity.Collections.NativeArray<T> data);
    public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
    public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize);
    public Rect[] PackTextures(Texture2D[] textures, int padding);
    public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps);
    public void ReadPixels(Rect source, int destX, int destY);
    public bool Resize(int width, int height);
    public bool Resize(int width, int height, TextureFormat format, bool hasMipMap);
    public void SetPixel(int x, int y, Color color);
    public void SetPixel(int x, int y, Color color, int mipLevel);
    public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel);
    public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors);
    public void SetPixels(Color[] colors, int miplevel);
    public void SetPixels(Color[] colors);
    public void SetPixels32(Color32[] colors, int miplevel);
    public void SetPixels32(Color32[] colors);
    public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel);
    public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors);
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
