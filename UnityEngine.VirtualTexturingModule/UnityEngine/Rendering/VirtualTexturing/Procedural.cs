using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public static class Procedural
{
    static public int GetCPUCacheSize();
    static public Rendering.VirtualTexturing.GPUCacheSetting[] GetGPUCacheSettings();
    static public void SetCPUCacheSize(int sizeInMegabytes);
    static public void SetGPUCacheSettings(Rendering.VirtualTexturing.GPUCacheSetting[] cacheSettings);

    public sealed class CPUTextureStack : TextureStackBase<CPUTextureStackRequestParameters>
    {
        public CPUTextureStack(string _name, CreationParameters creationParams);

    }

    public struct CPUTextureStackRequestLayerParameters
    {
        public void data;
        public int dataSize;
        public int scanlineSize;

    }

    public struct CPUTextureStackRequestParameters
    {
        public int height;
        public int level;
        public int numLayers;
        public int width;
        public int x;
        public int y;

        public void CopyPixelDataToLayer<T>(Unity.Collections.NativeArray<T> colorData, int layerIdx);
        public CPUTextureStackRequestLayerParameters GetLayer(int index);

    }

    public struct CreationParameters
    {
        static public int MaxNumLayers = 4;
        static public int MaxRequestsPerFrameSupported = 4095;

        public int height;
        public Experimental.Rendering.GraphicsFormat[] layers;
        public int maxActiveRequests;
        public int tilesize;
        public int width;

    }

    public sealed class GPUTextureStack : TextureStackBase<GPUTextureStackRequestParameters>
    {
        public GPUTextureStack(string _name, CreationParameters creationParams);

    }

    public struct GPUTextureStackRequestLayerParameters
    {
        public Rendering.RenderTargetIdentifier dest;
        public int destX;
        public int destY;

        public int GetHeight();
        public int GetWidth();

    }

    public struct GPUTextureStackRequestParameters
    {
        public int height;
        public int level;
        public int numLayers;
        public int width;
        public int x;
        public int y;

        public GPUTextureStackRequestLayerParameters GetLayer(int index);

    }

    public enum RequestStatus
    {
        Generated = 65538,
        Dropped = 65539,
    }

    public class TextureStackBase<T> : IDisposable
    {
        static public int AllMips = 2147483647;
        static public int borderSize;

        public TextureStackBase(string _name, CreationParameters _creationParams, bool gpuGeneration);

        public void BindGlobally();
        public void BindToMaterial(Material mat);
        public void BindToMaterialPropertyBlock(MaterialPropertyBlock mpb);
        public void Dispose();
        public void EvictRegion(Rect r, int mipMap, int numMips);
        public void InvalidateRegion(Rect r, int mipMap, int numMips);
        public bool IsValid();
        public int PopRequests(Unity.Collections.NativeSlice<TextureStackRequestHandle<T>> requestHandles);
        public void RequestRegion(Rect r, int mipMap, int numMips);

    }

    public struct TextureStackRequestHandle<T> : IEquatable<TextureStackRequestHandle<T>>
    {
        static public void CompleteRequests(Unity.Collections.NativeSlice<TextureStackRequestHandle<T>> requestHandles, Unity.Collections.NativeSlice<RequestStatus> status);
        static public void CompleteRequests(Unity.Collections.NativeSlice<TextureStackRequestHandle<T>> requestHandles, Unity.Collections.NativeSlice<RequestStatus> status, Rendering.CommandBuffer fenceBuffer);
        static public void GetRequestParameters(Unity.Collections.NativeSlice<TextureStackRequestHandle<T>> handles, Unity.Collections.NativeSlice<T> requests);

        public void CompleteRequest(RequestStatus status);
        public void CompleteRequest(RequestStatus status, Rendering.CommandBuffer fenceBuffer);
        public bool Equals(object obj);
        public bool Equals(TextureStackRequestHandle<T> other);
        public int GetHashCode();
        public T GetRequestParameters();

    }

}

}
