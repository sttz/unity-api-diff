using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Collider : Component
{
    public Rigidbody attachedRigidbody { get; }
    public Bounds bounds { get; }
    public float contactOffset { get; set; }
    public bool enabled { get; set; }
    public bool isTrigger { get; set; }
    public PhysicMaterial material { get; set; }
    public PhysicMaterial sharedMaterial { get; set; }

    public Collider();

    public Vector3 ClosestPoint(Vector3 position);
    public Vector3 ClosestPointOnBounds(Vector3 position);
    public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);

}

}
