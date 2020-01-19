using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class HingeJoint2D : AnchoredJoint2D
{
    public float jointAngle { get; }
    public float jointSpeed { get; }
    public JointAngleLimits2D limits { get; set; }
    public JointLimitState2D limitState { get; }
    public JointMotor2D motor { get; set; }
    public float referenceAngle { get; }
    public bool useLimits { get; set; }
    public bool useMotor { get; set; }

    public HingeJoint2D();

    public float GetMotorTorque(float timeStep);

}

}
