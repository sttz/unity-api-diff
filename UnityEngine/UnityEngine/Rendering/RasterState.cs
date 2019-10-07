using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct RasterState : IEquatable<Rendering.RasterState>
{
    static public Rendering.RasterState defaultValue;

    public Rendering.CullMode cullingMode { get; set; }
    public bool depthClip { get; set; }
    public float offsetFactor { get; set; }
    public int offsetUnits { get; set; }

    public RasterState(Rendering.CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = true);

    public bool Equals(Rendering.RasterState other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
