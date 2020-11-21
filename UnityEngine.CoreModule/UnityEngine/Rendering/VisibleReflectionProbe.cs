using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct VisibleReflectionProbe : IEquatable<Rendering.VisibleReflectionProbe>
{
    public float blendDistance { get; set; }
    public Bounds bounds { get; set; }
    public Vector3 center { get; set; }
    public Vector4 hdrData { get; set; }
    public int importance { get; set; }
    public bool isBoxProjection { get; set; }
    public Matrix4x4 localToWorldMatrix { get; set; }
    public ReflectionProbe reflectionProbe { get; }
    public Texture texture { get; }

    public bool Equals(object obj);
    public bool Equals(Rendering.VisibleReflectionProbe other);
    public int GetHashCode();

}

}
