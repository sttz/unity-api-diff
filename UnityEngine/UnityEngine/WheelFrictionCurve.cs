using System;
using UnityEngine;

namespace UnityEngine
{

public struct WheelFrictionCurve
{
    public float asymptoteSlip { get; set; }
    public float asymptoteValue { get; set; }
    public float extremumSlip { get; set; }
    public float extremumValue { get; set; }
    public float stiffness { get; set; }

}

}
