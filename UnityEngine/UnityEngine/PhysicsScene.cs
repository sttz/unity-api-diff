using System;
using UnityEngine;

namespace UnityEngine
{

public struct PhysicsScene : IEquatable<PhysicsScene>
{
    public bool Equals(object other);
    public bool Equals(PhysicsScene other);
    public int GetHashCode();
    public bool IsEmpty();
    public bool IsValid();
    public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0);
    public void Simulate(float step);
    public string ToString();

}

}
