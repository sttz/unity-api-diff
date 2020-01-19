using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Rigidbody2D : Component
{
    public float angularDrag { get; set; }
    public float angularVelocity { get; set; }
    public int attachedColliderCount { get; }
    public RigidbodyType2D bodyType { get; set; }
    public Vector2 centerOfMass { get; set; }
    public CollisionDetectionMode2D collisionDetectionMode { get; set; }
    public RigidbodyConstraints2D constraints { get; set; }
    public float drag { get; set; }
    public bool fixedAngle { get; set; }
    public bool freezeRotation { get; set; }
    public float gravityScale { get; set; }
    public float inertia { get; set; }
    public RigidbodyInterpolation2D interpolation { get; set; }
    public bool isKinematic { get; set; }
    public float mass { get; set; }
    public Vector2 position { get; set; }
    public float rotation { get; set; }
    public PhysicsMaterial2D sharedMaterial { get; set; }
    public bool simulated { get; set; }
    public RigidbodySleepMode2D sleepMode { get; set; }
    public bool useAutoMass { get; set; }
    public bool useFullKinematicContacts { get; set; }
    public Vector2 velocity { get; set; }
    public Vector2 worldCenterOfMass { get; }

    public Rigidbody2D();

    public void AddForce(Vector2 force);
    public void AddForce(Vector2 force, ForceMode2D mode);
    public void AddForceAtPosition(Vector2 force, Vector2 position);
    public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode);
    public void AddRelativeForce(Vector2 relativeForce);
    public void AddRelativeForce(Vector2 relativeForce, ForceMode2D mode);
    public void AddTorque(float torque);
    public void AddTorque(float torque, ForceMode2D mode);
    public int Cast(Vector2 direction, RaycastHit2D[] results);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int Cast(Vector2 direction, RaycastHit2D[] results, float distance);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    public ColliderDistance2D Distance(Collider2D collider);
    public int GetAttachedColliders(out Collider2D[] results);
    public int GetContacts(Collider2D[] colliders);
    public int GetContacts(ContactPoint2D[] contacts);
    public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders);
    public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts);
    public Vector2 GetPoint(Vector2 point);
    public Vector2 GetPointVelocity(Vector2 point);
    public Vector2 GetRelativePoint(Vector2 relativePoint);
    public Vector2 GetRelativePointVelocity(Vector2 relativePoint);
    public Vector2 GetRelativeVector(Vector2 relativeVector);
    public Vector2 GetVector(Vector2 vector);
    public bool IsAwake();
    public bool IsSleeping();
    public bool IsTouching(Collider2D collider);
    public bool IsTouching(ContactFilter2D contactFilter);
    public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter);
    public bool IsTouchingLayers();
    public bool IsTouchingLayers(int layerMask);
    public void MovePosition(Vector2 position);
    public void MoveRotation(float angle);
    public int OverlapCollider(ContactFilter2D contactFilter, out Collider2D[] results);
    public bool OverlapPoint(Vector2 point);
    public void Sleep();
    public void WakeUp();

}

}
