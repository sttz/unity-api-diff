using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct VisibleLight : IEquatable<Rendering.VisibleLight>
{
    public Color finalColor { get; set; }
    public bool intersectsFarPlane { get; set; }
    public bool intersectsNearPlane { get; set; }
    public Light light { get; }
    public LightType lightType { get; set; }
    public Matrix4x4 localToWorldMatrix { get; set; }
    public float range { get; set; }
    public Rect screenRect { get; set; }
    public float spotAngle { get; set; }

    public bool Equals(object obj);
    public bool Equals(Rendering.VisibleLight other);
    public int GetHashCode();

}

}
