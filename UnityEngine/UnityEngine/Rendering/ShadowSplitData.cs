using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ShadowSplitData : IEquatable<Rendering.ShadowSplitData>
{
    static public int maximumCullingPlaneCount;

    public int cullingPlaneCount { get; set; }
    public Vector4 cullingSphere { get; set; }
    public float shadowCascadeBlendCullingFactor { get; set; }

    public bool Equals(Rendering.ShadowSplitData other);
    public bool Equals(object obj);
    public Plane GetCullingPlane(int index);
    public int GetHashCode();
    public void SetCullingPlane(int index, Plane plane);

    public struct <m_CullingPlanes>e__FixedBuffer
    {
        public byte FixedElementField;

    }

}

}
