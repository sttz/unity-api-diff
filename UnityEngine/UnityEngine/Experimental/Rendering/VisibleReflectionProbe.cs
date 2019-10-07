using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct VisibleReflectionProbe
{
    public float blendDistance;
    public Bounds bounds;
    public int boxProjection;
    public Vector3 center;
    public Vector4 hdr;
    public int importance;
    public Matrix4x4 localToWorld;

    public ReflectionProbe probe { get; }
    public Texture texture { get; }

}

}
