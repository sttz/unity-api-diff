using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class EdgeCollider2D : Collider2D
{
    public Vector2 adjacentEndPoint { get; set; }
    public Vector2 adjacentStartPoint { get; set; }
    public int edgeCount { get; }
    public float edgeRadius { get; set; }
    public int pointCount { get; }
    public Vector2[] points { get; set; }
    public bool useAdjacentEndPoint { get; set; }
    public bool useAdjacentStartPoint { get; set; }

    public EdgeCollider2D();

    public int GetPoints(List<Vector2> points);
    public void Reset();
    public bool SetPoints(List<Vector2> points);

}

}
