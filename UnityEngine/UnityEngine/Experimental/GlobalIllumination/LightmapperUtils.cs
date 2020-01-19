using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public static class LightmapperUtils
{
    static public Experimental.GlobalIllumination.LightMode Extract(LightmapBakeType baketype);
    static public void Extract(Light l, Experimental.GlobalIllumination.DirectionalLight dir);
    static public void Extract(Light l, Experimental.GlobalIllumination.DiscLight disc);
    static public void Extract(Light l, Experimental.GlobalIllumination.PointLight point);
    static public void Extract(Light l, Experimental.GlobalIllumination.RectangleLight rect);
    static public void Extract(Light l, Experimental.GlobalIllumination.SpotLight spot);
    static public Experimental.GlobalIllumination.LinearColor ExtractIndirect(Light l);
    static public float ExtractInnerCone(Light l);

}

}
