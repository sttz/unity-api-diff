using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct RaycastHit2D
{
    public Vector2 centroid { get; set; }
    public Collider2D collider { get; }
    public float distance { get; set; }
    public float fraction { get; set; }
    public Vector2 normal { get; set; }
    public Vector2 point { get; set; }
    public Rigidbody2D rigidbody { get; }
    public Transform transform { get; }

    public int CompareTo(RaycastHit2D other);

}

}
