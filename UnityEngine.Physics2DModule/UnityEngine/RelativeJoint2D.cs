using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class RelativeJoint2D : Joint2D
{
    public float angularOffset { get; set; }
    public bool autoConfigureOffset { get; set; }
    public float correctionScale { get; set; }
    public Vector2 linearOffset { get; set; }
    public float maxForce { get; set; }
    public float maxTorque { get; set; }
    public Vector2 target { get; }

    public RelativeJoint2D();

}

}
