using System;
using UnityEngine;

namespace UnityEngine
{

public class ConfigurableJoint : Joint
{
    public JointDrive angularXDrive { get; set; }
    public SoftJointLimitSpring angularXLimitSpring { get; set; }
    public ConfigurableJointMotion angularXMotion { get; set; }
    public SoftJointLimit angularYLimit { get; set; }
    public ConfigurableJointMotion angularYMotion { get; set; }
    public JointDrive angularYZDrive { get; set; }
    public SoftJointLimitSpring angularYZLimitSpring { get; set; }
    public SoftJointLimit angularZLimit { get; set; }
    public ConfigurableJointMotion angularZMotion { get; set; }
    public bool configuredInWorldSpace { get; set; }
    public SoftJointLimit highAngularXLimit { get; set; }
    public SoftJointLimit linearLimit { get; set; }
    public SoftJointLimitSpring linearLimitSpring { get; set; }
    public SoftJointLimit lowAngularXLimit { get; set; }
    public float projectionAngle { get; set; }
    public float projectionDistance { get; set; }
    public JointProjectionMode projectionMode { get; set; }
    public RotationDriveMode rotationDriveMode { get; set; }
    public Vector3 secondaryAxis { get; set; }
    public JointDrive slerpDrive { get; set; }
    public bool swapBodies { get; set; }
    public Vector3 targetAngularVelocity { get; set; }
    public Vector3 targetPosition { get; set; }
    public Quaternion targetRotation { get; set; }
    public Vector3 targetVelocity { get; set; }
    public JointDrive xDrive { get; set; }
    public ConfigurableJointMotion xMotion { get; set; }
    public JointDrive yDrive { get; set; }
    public ConfigurableJointMotion yMotion { get; set; }
    public JointDrive zDrive { get; set; }
    public ConfigurableJointMotion zMotion { get; set; }

    public ConfigurableJoint();

}

}
