using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
{
    public Vector2 force { get; set; }
    public Vector2 relativeForce { get; set; }
    public float torque { get; set; }

    public ConstantForce2D();

}

}
