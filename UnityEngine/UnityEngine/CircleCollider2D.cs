using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class CircleCollider2D : Collider2D
{
    public Vector2 center { get; set; }
    public float radius { get; set; }

    public CircleCollider2D();

}

}
