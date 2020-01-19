using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct DirectionalLight
{
    public Experimental.GlobalIllumination.LinearColor color;
    public Vector3 direction;
    public Experimental.GlobalIllumination.LinearColor indirectColor;
    public int instanceID;
    public Experimental.GlobalIllumination.LightMode mode;
    public float penumbraWidthRadian;
    public bool shadow;

}

}
