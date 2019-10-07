using System;
using UnityEngine;

namespace UnityEngine
{

public class Physics
{
    static public int AllLayers = -1;
    static public int DefaultRaycastLayers = -5;
    static public int IgnoreRaycastLayer = 4;
    static public int kAllLayers = -1;
    static public int kDefaultRaycastLayers = -5;
    static public int kIgnoreRaycastLayer = 4;

    static public bool autoSimulation { get; set; }
    static public bool autoSyncTransforms { get; set; }
    static public float bounceThreshold { get; set; }
    static public float bounceTreshold { get; set; }
    static public Vector3 clothGravity { get; set; }
    static public float defaultContactOffset { get; set; }
    static public float defaultMaxAngularSpeed { get; set; }
    static public PhysicsScene defaultPhysicsScene { get; }
    static public int defaultSolverIterations { get; set; }
    static public int defaultSolverVelocityIterations { get; set; }
    static public Vector3 gravity { get; set; }
    static public float interCollisionDistance { get; set; }
    static public bool interCollisionSettingsToggle { get; set; }
    static public float interCollisionStiffness { get; set; }
    static public float maxAngularVelocity { get; set; }
    static public float minPenetrationForPenalty { get; set; }
    static public float penetrationPenaltyForce { get; set; }
    static public bool queriesHitBackfaces { get; set; }
    static public bool queriesHitTriggers { get; set; }
    static public bool reuseCollisionCallbacks { get; set; }
    static public float sleepAngularVelocity { get; set; }
    static public float sleepThreshold { get; set; }
    static public float sleepVelocity { get; set; }
    static public int solverIterationCount { get; set; }
    static public int solverVelocityIterationCount { get; set; }

    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation);
    static public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo);
    static public RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask);
    static public RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance);
    static public RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation);
    static public RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction);
    static public int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation);
    static public int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance);
    static public int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask);
    static public int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
    static public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo);
    static public RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask);
    static public RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance);
    static public RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction);
    static public int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
    static public int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance);
    static public int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results);
    static public bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask);
    static public bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation);
    static public bool CheckBox(Vector3 center, Vector3 halfExtents);
    static public bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask);
    static public bool CheckCapsule(Vector3 start, Vector3 end, float radius);
    static public bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool CheckSphere(Vector3 position, float radius, int layerMask);
    static public bool CheckSphere(Vector3 position, float radius);
    static public Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation);
    static public bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance);
    static public bool GetIgnoreCollision(Collider collider1, Collider collider2);
    static public bool GetIgnoreLayerCollision(int layer1, int layer2);
    static public void IgnoreCollision(Collider collider1, Collider collider2, bool ignore);
    static public void IgnoreCollision(Collider collider1, Collider collider2);
    static public void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
    static public void IgnoreLayerCollision(int layer1, int layer2);
    static public bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Linecast(Vector3 start, Vector3 end, int layerMask);
    static public bool Linecast(Vector3 start, Vector3 end);
    static public bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask);
    static public bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo);
    static public Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask);
    static public Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation);
    static public Collider[] OverlapBox(Vector3 center, Vector3 halfExtents);
    static public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction);
    static public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask);
    static public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation);
    static public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results);
    static public Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask);
    static public Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius);
    static public int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask);
    static public int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results);
    static public Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public Collider[] OverlapSphere(Vector3 position, float radius, int layerMask);
    static public Collider[] OverlapSphere(Vector3 position, float radius);
    static public int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask);
    static public int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results);
    static public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask);
    static public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance);
    static public bool Raycast(Vector3 origin, Vector3 direction);
    static public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
    static public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
    static public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo);
    static public bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Raycast(Ray ray, float maxDistance, int layerMask);
    static public bool Raycast(Ray ray, float maxDistance);
    static public bool Raycast(Ray ray);
    static public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask);
    static public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);
    static public bool Raycast(Ray ray, out RaycastHit hitInfo);
    static public RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask);
    static public RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance);
    static public RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction);
    static public RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask);
    static public RaycastHit[] RaycastAll(Ray ray, float maxDistance);
    static public RaycastHit[] RaycastAll(Ray ray);
    static public int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask);
    static public int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance);
    static public int RaycastNonAlloc(Ray ray, RaycastHit[] results);
    static public int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
    static public int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance);
    static public int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results);
    static public void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions);
    static public void Simulate(float step);
    static public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
    static public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
    static public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo);
    static public bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask);
    static public bool SphereCast(Ray ray, float radius, float maxDistance);
    static public bool SphereCast(Ray ray, float radius);
    static public bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask);
    static public bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance);
    static public bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo);
    static public RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask);
    static public RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance);
    static public RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction);
    static public RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask);
    static public RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance);
    static public RaycastHit[] SphereCastAll(Ray ray, float radius);
    static public int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
    static public int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance);
    static public int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results);
    static public int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    static public int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask);
    static public int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance);
    static public int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results);
    static public void SyncTransforms();

    public Physics();

}

}
