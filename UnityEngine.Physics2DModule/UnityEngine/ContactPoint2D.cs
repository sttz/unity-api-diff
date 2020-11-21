using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ContactPoint2D
{
    public Collider2D collider { get; }
    public bool enabled { get; }
    public Vector2 normal { get; }
    public float normalImpulse { get; }
    public Collider2D otherCollider { get; }
    public Rigidbody2D otherRigidbody { get; }
    public Vector2 point { get; }
    public Vector2 relativeVelocity { get; }
    public Rigidbody2D rigidbody { get; }
    public float separation { get; }
    public float tangentImpulse { get; }

}

}
