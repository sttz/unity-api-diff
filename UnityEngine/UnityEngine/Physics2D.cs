using System;
using UnityEngine;

namespace UnityEngine
{

public class Physics2D
{
    static public int AllLayers = -1;
    static public int DefaultRaycastLayers = -5;
    static public int IgnoreRaycastLayer = 4;

    static public bool alwaysShowColliders { get; set; }
    static public float angularSleepTolerance { get; set; }
    static public bool autoSimulation { get; set; }
    static public bool autoSyncTransforms { get; set; }
    static public float baumgarteScale { get; set; }
    static public float baumgarteTOIScale { get; set; }
    static public bool callbacksOnDisable { get; set; }
    static public bool changeStopsCallbacks { get; set; }
    static public Color colliderAABBColor { get; set; }
    static public Color colliderAsleepColor { get; set; }
    static public Color colliderAwakeColor { get; set; }
    static public Color colliderContactColor { get; set; }
    static public float contactArrowScale { get; set; }
    static public float defaultContactOffset { get; set; }
    static public PhysicsScene2D defaultPhysicsScene { get; }
    static public bool deleteStopsCallbacks { get; set; }
    static public Vector2 gravity { get; set; }
    static public PhysicsJobOptions2D jobOptions { get; set; }
    static public float linearSleepTolerance { get; set; }
    static public float maxAngularCorrection { get; set; }
    static public float maxLinearCorrection { get; set; }
    static public float maxRotationSpeed { get; set; }
    static public float maxTranslationSpeed { get; set; }
    static public float minPenetrationForPenalty { get; set; }
    static public int positionIterations { get; set; }
    static public bool queriesHitTriggers { get; set; }
    static public bool queriesStartInColliders { get; set; }
    static public bool raycastsHitTriggers { get; set; }
    static public bool raycastsStartInColliders { get; set; }
    static public bool reuseCollisionCallbacks { get; set; }
    static public bool showColliderAABB { get; set; }
    static public bool showColliderContacts { get; set; }
    static public bool showColliderSleep { get; set; }
    static public float timeToSleep { get; set; }
    static public int velocityIterations { get; set; }
    static public float velocityThreshold { get; set; }

    static public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction);
    static public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
    static public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    static public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    static public RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction);
    static public RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
    static public RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results);
    static public int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
    static public int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
    static public int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
    static public int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
    static public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
    static public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
    static public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    static public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    static public RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
    static public RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
    static public RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results);
    static public int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
    static public int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
    static public int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
    static public int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
    static public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction);
    static public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance);
    static public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    static public int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    static public RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction);
    static public RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance);
    static public RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results);
    static public int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance);
    static public int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
    static public int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
    static public int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
    static public ColliderDistance2D Distance(Collider2D colliderA, Collider2D colliderB);
    static public int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
    static public int GetContacts(Collider2D collider, ContactPoint2D[] contacts);
    static public int GetContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
    static public int GetContacts(Collider2D collider, Collider2D[] colliders);
    static public int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] colliders);
    static public int GetContacts(Rigidbody2D rigidbody, ContactPoint2D[] contacts);
    static public int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
    static public int GetContacts(Rigidbody2D rigidbody, Collider2D[] colliders);
    static public int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders);
    static public bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2);
    static public bool GetIgnoreLayerCollision(int layer1, int layer2);
    static public int GetLayerCollisionMask(int layer);
    static public RaycastHit2D GetRayIntersection(Ray ray);
    static public RaycastHit2D GetRayIntersection(Ray ray, float distance);
    static public RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask);
    static public RaycastHit2D[] GetRayIntersectionAll(Ray ray);
    static public RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance);
    static public RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask);
    static public int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results);
    static public int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance);
    static public int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask);
    static public void IgnoreCollision(Collider2D collider1, Collider2D collider2);
    static public void IgnoreCollision(Collider2D collider1, Collider2D collider2, bool ignore);
    static public void IgnoreLayerCollision(int layer1, int layer2);
    static public void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
    static public bool IsTouching(Collider2D collider1, Collider2D collider2);
    static public bool IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter);
    static public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter);
    static public bool IsTouchingLayers(Collider2D collider);
    static public bool IsTouchingLayers(Collider2D collider, int layerMask);
    static public RaycastHit2D Linecast(Vector2 start, Vector2 end);
    static public RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask);
    static public RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth);
    static public RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth);
    static public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results);
    static public RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end);
    static public RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask);
    static public RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth);
    static public RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth);
    static public int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results);
    static public int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask);
    static public int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth);
    static public int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth, float maxDepth);
    static public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB);
    static public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask);
    static public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
    static public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth);
    static public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB);
    static public Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask);
    static public Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
    static public Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth);
    static public int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results);
    static public int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask);
    static public int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth);
    static public int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth, float maxDepth);
    static public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle);
    static public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask);
    static public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
    static public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth);
    static public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle);
    static public Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask);
    static public Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
    static public Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth);
    static public int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results);
    static public int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask);
    static public int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask, float minDepth);
    static public int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask, float minDepth, float maxDepth);
    static public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
    static public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
    static public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
    static public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth);
    static public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
    static public Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
    static public Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
    static public Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth);
    static public int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results);
    static public int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask);
    static public int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask, float minDepth);
    static public int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask, float minDepth, float maxDepth);
    static public Collider2D OverlapCircle(Vector2 point, float radius);
    static public Collider2D OverlapCircle(Vector2 point, float radius, int layerMask);
    static public Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth);
    static public Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);
    static public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D[] OverlapCircleAll(Vector2 point, float radius);
    static public Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask);
    static public Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth);
    static public Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);
    static public int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results);
    static public int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask);
    static public int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth);
    static public int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth, float maxDepth);
    static public int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D OverlapPoint(Vector2 point);
    static public Collider2D OverlapPoint(Vector2 point, int layerMask);
    static public Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth);
    static public Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth, float maxDepth);
    static public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results);
    static public Collider2D[] OverlapPointAll(Vector2 point);
    static public Collider2D[] OverlapPointAll(Vector2 point, int layerMask);
    static public Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth);
    static public Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth, float maxDepth);
    static public int OverlapPointNonAlloc(Vector2 point, Collider2D[] results);
    static public int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask);
    static public int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth);
    static public int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth, float maxDepth);
    static public RaycastHit2D Raycast(Vector2 origin, Vector2 direction);
    static public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance);
    static public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
    static public int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
    static public RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction);
    static public RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance);
    static public RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask);
    static public RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
    static public RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
    static public int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results);
    static public int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance);
    static public int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
    static public int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
    static public int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
    static public void SetLayerCollisionMask(int layer, int layerMask);
    static public bool Simulate(float step);
    static public void SyncTransforms();

    public Physics2D();

}

}
