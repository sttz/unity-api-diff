using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class HingeJoint : Joint
{
    public float angle { get; }
    public JointLimits limits { get; set; }
    public JointMotor motor { get; set; }
    public JointSpring spring { get; set; }
    public bool useLimits { get; set; }
    public bool useMotor { get; set; }
    public bool useSpring { get; set; }
    public float velocity { get; }

    public HingeJoint();

}

}
