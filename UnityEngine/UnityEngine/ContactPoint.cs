using System;
using UnityEngine;

namespace UnityEngine
{

public struct ContactPoint
{
    public Vector3 normal { get; }
    public Collider otherCollider { get; }
    public Vector3 point { get; }
    public float separation { get; }
    public Collider thisCollider { get; }

}

}
