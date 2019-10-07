using System;
using UnityEngine;

namespace UnityEngine
{

public class BuoyancyEffector2D : Effector2D
{
    public float angularDrag { get; set; }
    public float density { get; set; }
    public float flowAngle { get; set; }
    public float flowMagnitude { get; set; }
    public float flowVariation { get; set; }
    public float linearDrag { get; set; }
    public float surfaceLevel { get; set; }

    public BuoyancyEffector2D();

}

}
