using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing.Procedural
{

public class TextureStackBase<T> : IDisposable
{
    static public int AllMips = 2147483647;
    static public int borderSize;

    public TextureStackBase(string _name, Rendering.VirtualTexturing.Procedural.CreationParameters _creationParams, bool gpuGeneration);

    public void BindGlobally();
    public void BindToMaterial(Material mat);
    public void BindToMaterialPropertyBlock(MaterialPropertyBlock mpb);
    public void Dispose();
    public void InvalidateRegion(Rect r, int mipMap, int numMips);
    public bool IsValid();
    public int PopRequests(Unity.Collections.NativeSlice<Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> requestHandles);
    public void RequestRegion(Rect r, int mipMap, int numMips);

}

}
