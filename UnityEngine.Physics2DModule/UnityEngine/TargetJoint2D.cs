using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TargetJoint2D : Joint2D
{
    public Vector2 anchor { get; set; }
    public bool autoConfigureTarget { get; set; }
    public float dampingRatio { get; set; }
    public float frequency { get; set; }
    public float maxForce { get; set; }
    public Vector2 target { get; set; }

    public TargetJoint2D();

}

}
