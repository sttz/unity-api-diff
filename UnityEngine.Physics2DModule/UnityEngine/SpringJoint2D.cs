using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class SpringJoint2D : AnchoredJoint2D
{
    public bool autoConfigureDistance { get; set; }
    public float dampingRatio { get; set; }
    public float distance { get; set; }
    public float frequency { get; set; }

    public SpringJoint2D();

}

}
