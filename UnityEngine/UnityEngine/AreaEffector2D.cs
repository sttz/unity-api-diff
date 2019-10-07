using System;
using UnityEngine;

namespace UnityEngine
{

public class AreaEffector2D : Effector2D
{
    public float angularDrag { get; set; }
    public float drag { get; set; }
    public float forceAngle { get; set; }
    public float forceDirection { get; set; }
    public float forceMagnitude { get; set; }
    public EffectorSelection2D forceTarget { get; set; }
    public float forceVariation { get; set; }
    public bool useGlobalAngle { get; set; }

    public AreaEffector2D();

}

}
