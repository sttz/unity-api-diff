using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct DiscLight
{
    public Experimental.GlobalIllumination.LinearColor color;
    public Experimental.GlobalIllumination.FalloffType falloff;
    public Experimental.GlobalIllumination.LinearColor indirectColor;
    public int instanceID;
    public Experimental.GlobalIllumination.LightMode mode;
    public Quaternion orientation;
    public Vector3 position;
    public float radius;
    public float range;
    public bool shadow;

}

}
