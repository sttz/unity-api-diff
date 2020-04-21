using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Bounds : IEquatable<Bounds>, IFormattable
{
    public Vector3 center { get; set; }
    public Vector3 extents { get; set; }
    public Vector3 max { get; set; }
    public Vector3 min { get; set; }
    public Vector3 size { get; set; }

    public Bounds(Vector3 center, Vector3 size);

    public Vector3 ClosestPoint(Vector3 point);
    public bool Contains(Vector3 point);
    public void Encapsulate(Bounds bounds);
    public void Encapsulate(Vector3 point);
    public bool Equals(object other);
    public bool Equals(Bounds other);
    public void Expand(float amount);
    public void Expand(Vector3 amount);
    public int GetHashCode();
    public bool IntersectRay(Ray ray);
    public bool IntersectRay(Ray ray, out float distance);
    public bool Intersects(Bounds bounds);
    public void SetMinMax(Vector3 min, Vector3 max);
    public float SqrDistance(Vector3 point);
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
