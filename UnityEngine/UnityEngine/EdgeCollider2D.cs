using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class EdgeCollider2D : Collider2D
{
    public int edgeCount { get; }
    public float edgeRadius { get; set; }
    public int pointCount { get; }
    public Vector2[] points { get; set; }

    public EdgeCollider2D();

    public void Reset();

}

}
