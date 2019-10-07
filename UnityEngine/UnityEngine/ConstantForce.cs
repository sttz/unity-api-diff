using System;
using UnityEngine;

namespace UnityEngine
{

public class ConstantForce : Behaviour
{
    public Vector3 force { get; set; }
    public Vector3 relativeForce { get; set; }
    public Vector3 relativeTorque { get; set; }
    public Vector3 torque { get; set; }

    public ConstantForce();

}

}
