using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct RenderTargetIdentifier : IEquatable<Rendering.RenderTargetIdentifier>
{
    public RenderTargetIdentifier(Rendering.BuiltinRenderTextureType type);
    public RenderTargetIdentifier(string name);
    public RenderTargetIdentifier(string name, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0);
    public RenderTargetIdentifier(int nameID);
    public RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0);
    public RenderTargetIdentifier(Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0);
    public RenderTargetIdentifier(Texture tex);
    public RenderTargetIdentifier(Texture tex, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0);
    public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0);

    public bool Equals(Rendering.RenderTargetIdentifier rhs);
    public bool Equals(object obj);
    public int GetHashCode();
    public string ToString();

}

}
