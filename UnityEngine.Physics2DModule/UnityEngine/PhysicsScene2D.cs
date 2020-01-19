using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct PhysicsScene2D : IEquatable<PhysicsScene2D>
{
    static public int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results);
    static public int OverlapCollider(Collider2D collider, Collider2D[] results, int layerMask = -5);

    public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter);
    public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask = -5);
    public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, RaycastHit2D[] results, int layerMask = -5);
    public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter);
    public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask = -5);
    public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, RaycastHit2D[] results, int layerMask = -5);
    public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter);
    public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask = -5);
    public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, RaycastHit2D[] results, int layerMask = -5);
    public bool Equals(object other);
    public bool Equals(PhysicsScene2D other);
    public int GetHashCode();
    public RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5);
    public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5);
    public bool IsEmpty();
    public bool IsValid();
    public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter);
    public RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask = -5);
    public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int Linecast(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask = -5);
    public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter);
    public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask = -5);
    public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapArea(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask = -5);
    public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter);
    public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask = -5);
    public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapBox(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask = -5);
    public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter);
    public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask = -5);
    public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask = -5);
    public Collider2D OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter);
    public Collider2D OverlapCircle(Vector2 point, float radius, int layerMask = -5);
    public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapCircle(Vector2 point, float radius, Collider2D[] results, int layerMask = -5);
    public Collider2D OverlapPoint(Vector2 point, ContactFilter2D contactFilter);
    public Collider2D OverlapPoint(Vector2 point, int layerMask = -5);
    public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapPoint(Vector2 point, Collider2D[] results, int layerMask = -5);
    public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter);
    public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5);
    public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int Raycast(Vector2 origin, Vector2 direction, float distance, RaycastHit2D[] results, int layerMask = -5);
    public bool Simulate(float step);
    public string ToString();

}

}
