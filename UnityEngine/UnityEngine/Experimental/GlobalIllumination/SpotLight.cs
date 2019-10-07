using System;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct SpotLight
{
    public Experimental.GlobalIllumination.AngularFalloffType angularFalloff;
    public Experimental.GlobalIllumination.LinearColor color;
    public float coneAngle;
    public Experimental.GlobalIllumination.FalloffType falloff;
    public Experimental.GlobalIllumination.LinearColor indirectColor;
    public float innerConeAngle;
    public int instanceID;
    public Experimental.GlobalIllumination.LightMode mode;
    public Quaternion orientation;
    public Vector3 position;
    public float range;
    public bool shadow;
    public float sphereRadius;

}

}
