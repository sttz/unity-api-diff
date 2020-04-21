using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct Cookie
{
    static public Experimental.GlobalIllumination.Cookie Defaults();

    public int instanceID;
    public float scale;
    public Vector2 sizes;

}

}
