using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public static class Lightmapping
{
    static public RequestLightsDelegate GetDelegate();
    static public void ResetDelegate();
    static public void SetDelegate(RequestLightsDelegate del);

    public delegate void RequestLightsDelegate(Light[] requests, Unity.Collections.NativeArray<Experimental.GlobalIllumination.LightDataGI> lightsOutput);

}

}
