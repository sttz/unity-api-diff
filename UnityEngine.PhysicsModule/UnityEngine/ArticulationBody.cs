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
    public Vector3 centerOfMass { get; set; }
    public int dofCount { get; }
    public bool immovable { get; set; }
    public Vector3 inertiaTensor { get; set; }
    public Quaternion inertiaTensorRotation { get; set; }
    public bool isRoot { get; }
    public ArticulationReducedSpace jointAcceleration { get; set; }
    public ArticulationReducedSpace jointForce { get; set; }
    public float jointFriction { get; set; }
    public ArticulationReducedSpace jointPosition { get; set; }
    public ArticulationJointType jointType { get; set; }
    public ArticulationReducedSpace jointVelocity { get; set; }
    public float linearDamping { get; set; }
    public ArticulationDofLock linearLockX { get; set; }
    public ArticulationDofLock linearLockY { get; set; }
    public ArticulationDofLock linearLockZ { get; set; }
    public float mass { get; set; }
    public float maxAngularVelocity { get; set; }
    public float maxDepenetrationVelocity { get; set; }
    public Vector3 parentAnchorPosition { get; set; }
    public Quaternion parentAnchorRotation { get; set; }
    public float sleepThreshold { get; set; }
    public int solverIterations { get; set; }
    public int solverVelocityIterations { get; set; }
    public ArticulationDofLock swingYLock { get; set; }
    public ArticulationDofLock swingZLock { get; set; }
    public ArticulationDofLock twistLock { get; set; }
    public bool useGravity { get; set; }
    public Vector3 velocity { get; }
    public Vector3 worldCenterOfMass { get; }
    public ArticulationDrive xDrive { get; set; }
    public ArticulationDrive yDrive { get; set; }
    public ArticulationDrive zDrive { get; set; }

    public ArticulationBody();

    public void AddForce(Vector3 force);
    public void AddForceAtPosition(Vector3 force, Vector3 position);
    public void AddRelativeForce(Vector3 force);
    public void AddRelativeTorque(Vector3 torque);
    public void AddTorque(Vector3 torque);
    public Vector3 GetClosestPoint(Vector3 point);
    public Vector3 GetPointVelocity(Vector3 worldPoint);
    public Vector3 GetRelativePointVelocity(Vector3 relativePoint);
    public bool IsSleeping();
    public void ResetCenterOfMass();
    public void ResetInertiaTensor();
    public void Sleep();
    public void TeleportRoot(Vector3 position, Quaternion rotation);
    public void WakeUp();

}

}
