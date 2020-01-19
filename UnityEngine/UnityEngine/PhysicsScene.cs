using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct PhysicsScene : IEquatable<PhysicsScene>
{
    public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo);
    public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results);
    public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public bool Equals(object other);
    public bool Equals(PhysicsScene other);
    public int GetHashCode();
    public bool IsEmpty();
    public bool IsValid();
    public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results);
    public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
    public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public void Simulate(float step);
    public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public string ToString();

}

}
