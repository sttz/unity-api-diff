using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class WheelJoint2D : AnchoredJoint2D
{
    public float jointAngle { get; }
    public float jointLinearSpeed { get; }
    public float jointSpeed { get; }
    public float jointTranslation { get; }
    public JointMotor2D motor { get; set; }
    public JointSuspension2D suspension { get; set; }
    public bool useMotor { get; set; }

    public WheelJoint2D();

    public float GetMotorTorque(float timeStep);

}

}
