using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class FixedJoint2D : AnchoredJoint2D
{
    public float dampingRatio { get; set; }
    public float frequency { get; set; }
    public float referenceAngle { get; }

    public FixedJoint2D();

}

}
