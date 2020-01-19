using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class DistanceJoint2D : AnchoredJoint2D
{
    public bool autoConfigureDistance { get; set; }
    public float distance { get; set; }
    public bool maxDistanceOnly { get; set; }

    public DistanceJoint2D();

}

}
