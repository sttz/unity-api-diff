using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class PolygonCollider2D : Collider2D
{
    public bool autoTiling { get; set; }
    public int pathCount { get; set; }
    public Vector2[] points { get; set; }

    public PolygonCollider2D();

    public void CreatePrimitive(int sides);
    public void CreatePrimitive(int sides, Vector2 scale);
    public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset);
    public Vector2[] GetPath(int index);
    public int GetTotalPointCount();
    public void SetPath(int index, Vector2[] points);

}

}
