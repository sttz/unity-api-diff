using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class CharacterJoint : Joint
{
    public JointDrive rotationDrive;
    public Vector3 targetAngularVelocity;
    public Quaternion targetRotation;

    public bool enableProjection { get; set; }
    public SoftJointLimit highTwistLimit { get; set; }
    public SoftJointLimit lowTwistLimit { get; set; }
    public float projectionAngle { get; set; }
    public float projectionDistance { get; set; }
    public SoftJointLimit swing1Limit { get; set; }
    public SoftJointLimit swing2Limit { get; set; }
    public Vector3 swingAxis { get; set; }
    public SoftJointLimitSpring swingLimitSpring { get; set; }
    public SoftJointLimitSpring twistLimitSpring { get; set; }

    public CharacterJoint();

}

}
