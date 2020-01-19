using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class ArticulationBody : Behaviour
{
    public Vector3 anchorPosition { get; set; }
    public Quaternion anchorRotation { get; set; }
    public float angularDamping { get; set; }
    public Vector3 angularVelocity { get; }
    public Vector3 centerOfMass { get; }
    public bool immovable { get; set; }
    public Vector3 inertiaTensor { get; }
    public bool isRoot { get; }
    public float jointFriction { get; set; }
    public ArticulationJointType jointType { get; set; }
    public float linearDamping { get; set; }
    public ArticulationDofLock linearLockX { get; set; }
    public ArticulationDofLock linearLockY { get; set; }
    public ArticulationDofLock linearLockZ { get; set; }
    public float mass { get; set; }
    public Vector3 parentAnchorPosition { get; set; }
    public Quaternion parentAnchorRotation { get; set; }
    public ArticulationDofLock swingYLock { get; set; }
    public ArticulationDofLock swingZLock { get; set; }
    public ArticulationDofLock twistLock { get; set; }
    public Vector3 velocity { get; }
    public ArticulationDrive xDrive { get; set; }
    public ArticulationDrive yDrive { get; set; }
    public ArticulationDrive zDrive { get; set; }

    public ArticulationBody();

    public void AddForce(Vector3 force);
    public void AddTorque(Vector3 torque);
    public Vector3 GetClosestPoint(Vector3 point);
    public void TeleportRoot(Vector3 position, Quaternion rotation);

}

}
