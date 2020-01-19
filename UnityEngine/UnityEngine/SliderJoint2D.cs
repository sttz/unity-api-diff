using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class SliderJoint2D : AnchoredJoint2D
{
    public float angle { get; set; }
    public bool autoConfigureAngle { get; set; }
    public float jointSpeed { get; }
    public float jointTranslation { get; }
    public JointTranslationLimits2D limits { get; set; }
    public JointLimitState2D limitState { get; }
    public JointMotor2D motor { get; set; }
    public float referenceAngle { get; }
    public bool useLimits { get; set; }
    public bool useMotor { get; set; }

    public SliderJoint2D();

    public float GetMotorForce(float timeStep);

}

}
