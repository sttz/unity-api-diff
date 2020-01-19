using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class CompositeCollider2D : Collider2D
{
    public float edgeRadius { get; set; }
    public GenerationType generationType { get; set; }
    public GeometryType geometryType { get; set; }
    public float offsetDistance { get; set; }
    public int pathCount { get; }
    public int pointCount { get; }
    public float vertexDistance { get; set; }

    public CompositeCollider2D();

    public void GenerateGeometry();
    public int GetPath(int index, List<Vector2> points);
    public int GetPath(int index, Vector2[] points);
    public int GetPathPointCount(int index);

    public enum GenerationType
    {
        Synchronous = 0,
        Manual = 1,
    }

    public enum GeometryType
    {
        Outlines = 0,
        Polygons = 1,
    }

}

}
