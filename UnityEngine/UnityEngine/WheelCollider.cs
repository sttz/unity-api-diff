using System;
using UnityEngine;

namespace UnityEngine
{

public class WheelCollider : Collider
{
    public float brakeTorque { get; set; }
    public Vector3 center { get; set; }
    public float forceAppPointDistance { get; set; }
    public WheelFrictionCurve forwardFriction { get; set; }
    public bool isGrounded { get; }
    public float mass { get; set; }
    public float motorTorque { get; set; }
    public float radius { get; set; }
    public float rpm { get; }
    public WheelFrictionCurve sidewaysFriction { get; set; }
    public float sprungMass { get; }
    public float steerAngle { get; set; }
    public float suspensionDistance { get; set; }
    public JointSpring suspensionSpring { get; set; }
    public float wheelDampingRate { get; set; }

    public WheelCollider();

    public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);
    public bool GetGroundHit(out WheelHit hit);
    public void GetWorldPose(out Vector3 pos, out Quaternion quat);

}

}
