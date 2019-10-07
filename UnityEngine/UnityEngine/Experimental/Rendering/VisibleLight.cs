using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct VisibleLight
{
    public Color finalColor;
    public Experimental.Rendering.VisibleLightFlags flags;
    public LightType lightType;
    public Matrix4x4 localToWorld;
    public float range;
    public Rect screenRect;
    public float spotAngle;

    public Light light { get; }

}

}
