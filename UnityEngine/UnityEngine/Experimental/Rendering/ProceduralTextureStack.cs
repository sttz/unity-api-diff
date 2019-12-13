using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public sealed class ProceduralTextureStack : IDisposable
{
    static public int AllMips = 2147483647;
    static public uint borderSize;

    public ProceduralTextureStack(string _name, Experimental.Rendering.ProceduralTextureStackCreationParams creationParams);

    public void BindToMaterial(Material mat);
    public void BindToMaterialPropertyBlock(MaterialPropertyBlock mpb);
    public void Dispose();
    public Experimental.Rendering.ProceduralRequestList GetActiveRequests();
    public void InvalidateRegion(Rect r, int mipMap, int numMips);
    public void RequestRegion(Rect r, int mipMap, int numMips);

}

}
