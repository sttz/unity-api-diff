using System;
using UnityEngine;

namespace UnityEngine
{

public class Rigidbody : Component
{
    public float angularDrag { get; set; }
    public Vector3 angularVelocity { get; set; }
    public Vector3 centerOfMass { get; set; }
    public CollisionDetectionMode collisionDetectionMode { get; set; }
    public RigidbodyConstraints constraints { get; set; }
    public bool detectCollisions { get; set; }
    public float drag { get; set; }
    public bool freezeRotation { get; set; }
    public Vector3 inertiaTensor { get; set; }
    public Quaternion inertiaTensorRotation { get; set; }
    public RigidbodyInterpolation interpolation { get; set; }
    public bool isKinematic { get; set; }
    public float mass { get; set; }
    public float maxAngularVelocity { get; set; }
    public float maxDepenetrationVelocity { get; set; }
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }
    public float sleepAngularVelocity { get; set; }
    public float sleepThreshold { get; set; }
    public float sleepVelocity { get; set; }
    public int solverIterationCount { get; set; }
    public int solverIterations { get; set; }
    public int solverVelocityIterationCount { get; set; }
    public int solverVelocityIterations { get; set; }
    public bool useConeFriction { get; set; }
    public bool useGravity { get; set; }
    public Vector3 velocity { get; set; }
    public Vector3 worldCenterOfMass { get; }

    public Rigidbody();

    public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);
    public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier);
    public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius);
    public void AddForce(Vector3 force, ForceMode mode);
    public void AddForce(Vector3 force);
    public void AddForce(float x, float y, float z, ForceMode mode);
    public void AddForce(float x, float y, float z);
    public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode);
    public void AddForceAtPosition(Vector3 force, Vector3 position);
    public void AddRelativeForce(Vector3 force, ForceMode mode);
    public void AddRelativeForce(Vector3 force);
    public void AddRelativeForce(float x, float y, float z, ForceMode mode);
    public void AddRelativeForce(float x, float y, float z);
    public void AddRelativeTorque(Vector3 torque, ForceMode mode);
    public void AddRelativeTorque(Vector3 torque);
    public void AddRelativeTorque(float x, float y, float z, ForceMode mode);
    public void AddRelativeTorque(float x, float y, float z);
    public void AddTorque(Vector3 torque, ForceMode mode);
    public void AddTorque(Vector3 torque);
    public void AddTorque(float x, float y, float z, ForceMode mode);
    public void AddTorque(float x, float y, float z);
    public Vector3 ClosestPointOnBounds(Vector3 position);
    public Vector3 GetPointVelocity(Vector3 worldPoint);
    public Vector3 GetRelativePointVelocity(Vector3 relativePoint);
    public bool IsSleeping();
    public void MovePosition(Vector3 position);
    public void MoveRotation(Quaternion rot);
    public void ResetCenterOfMass();
    public void ResetInertiaTensor();
    public void SetDensity(float density);
    public void SetMaxAngularVelocity(float a);
    public void Sleep();
    public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);
    public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance);
    public bool SweepTest(Vector3 direction, out RaycastHit hitInfo);
    public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);
    public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance);
    public RaycastHit[] SweepTestAll(Vector3 direction);
    public void WakeUp();

}

}
