using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct LinearColor
{
    static public Experimental.GlobalIllumination.LinearColor Black();
    static public Experimental.GlobalIllumination.LinearColor Convert(Color color, float intensity);

    public float blue { get; set; }
    public float green { get; set; }
    public float intensity { get; set; }
    public float red { get; set; }

}

}
