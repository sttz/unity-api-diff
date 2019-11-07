using System;
using UnityEngine;

namespace UnityEngine
{

public struct Vector4 : IEquatable<Vector4>, IFormattable
{
    static public float kEpsilon = 1E-05;

    static public Vector4 negativeInfinity { get; }
    static public Vector4 one { get; }
    static public Vector4 positiveInfinity { get; }
    static public Vector4 zero { get; }

    static public float Distance(Vector4 a, Vector4 b);
    static public float Dot(Vector4 a, Vector4 b);
    static public Vector4 Lerp(Vector4 a, Vector4 b, float t);
    static public Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t);
    static public float Magnitude(Vector4 a);
    static public Vector4 Max(Vector4 lhs, Vector4 rhs);
    static public Vector4 Min(Vector4 lhs, Vector4 rhs);
    static public Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta);
    static public Vector4 Normalize(Vector4 a);
    static public Vector4 Project(Vector4 a, Vector4 b);
    static public Vector4 Scale(Vector4 a, Vector4 b);
    static public float SqrMagnitude(Vector4 a);

    public float w;
    public float x;
    public float y;
    public float z;

    public float this[int index] { get; set; }
    public float magnitude { get; }
    public Vector4 normalized { get; }
    public float sqrMagnitude { get; }

    public Vector4(float x, float y, float z, float w);
    public Vector4(float x, float y, float z);
    public Vector4(float x, float y);

    public bool Equals(object other);
    public bool Equals(Vector4 other);
    public int GetHashCode();
    public void Normalize();
    public void Scale(Vector4 scale);
    public void Set(float newX, float newY, float newZ, float newW);
    public float SqrMagnitude();
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
