using System;
using UnityEngine;

namespace UnityEngine
{

public class Collider2D : Behaviour
{
    public Rigidbody2D attachedRigidbody { get; }
    public float bounciness { get; }
    public Bounds bounds { get; }
    public CompositeCollider2D composite { get; }
    public float density { get; set; }
    public float friction { get; }
    public bool isTrigger { get; set; }
    public Vector2 offset { get; set; }
    public int shapeCount { get; }
    public PhysicsMaterial2D sharedMaterial { get; set; }
    public bool usedByComposite { get; set; }
    public bool usedByEffector { get; set; }

    public Collider2D();

    public int Cast(Vector2 direction, RaycastHit2D[] results);
    public int Cast(Vector2 direction, RaycastHit2D[] results, float distance);
    public int Cast(Vector2 direction, RaycastHit2D[] results, float distance, bool ignoreSiblingColliders);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance, bool ignoreSiblingColliders);
    public int Cast(Vector2 direction, ContactFilter2D contactFilter, System.Collections.Generic.List<RaycastHit2D> results, float distance = ∞, bool ignoreSiblingColliders = true);
    public Vector2 ClosestPoint(Vector2 position);
    public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation);
    public ColliderDistance2D Distance(Collider2D collider);
    public int GetContacts(ContactPoint2D[] contacts);
    public int GetContacts(System.Collections.Generic.List<ContactPoint2D> contacts);
    public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts);
    public int GetContacts(ContactFilter2D contactFilter, System.Collections.Generic.List<ContactPoint2D> contacts);
    public int GetContacts(Collider2D[] colliders);
    public int GetContacts(System.Collections.Generic.List<Collider2D> colliders);
    public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders);
    public int GetContacts(ContactFilter2D contactFilter, System.Collections.Generic.List<Collider2D> colliders);
    public uint GetShapeHash();
    public bool IsTouching(Collider2D collider);
    public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter);
    public bool IsTouching(ContactFilter2D contactFilter);
    public bool IsTouchingLayers();
    public bool IsTouchingLayers(int layerMask);
    public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results);
    public int OverlapCollider(ContactFilter2D contactFilter, System.Collections.Generic.List<Collider2D> results);
    public bool OverlapPoint(Vector2 point);
    public int Raycast(Vector2 direction, RaycastHit2D[] results);
    public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance);
    public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
    public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
    public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
    public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    public int Raycast(Vector2 direction, ContactFilter2D contactFilter, System.Collections.Generic.List<RaycastHit2D> results, float distance = ∞);

}

}
