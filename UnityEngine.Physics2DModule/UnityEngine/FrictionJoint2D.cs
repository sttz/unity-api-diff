using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class FrictionJoint2D : AnchoredJoint2D
{
    public float maxForce { get; set; }
    public float maxTorque { get; set; }

    public FrictionJoint2D();

}

}
