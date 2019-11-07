using System;
using UnityEngine;

namespace UnityEngine
{

public struct Vector2 : IEquatable<Vector2>, IFormattable
{
    static public float kEpsilon = 1E-05;
    static public float kEpsilonNormalSqrt = 1E-15;

    static public Vector2 down { get; }
    static public Vector2 left { get; }
    static public Vector2 negativeInfinity { get; }
    static public Vector2 one { get; }
    static public Vector2 positiveInfinity { get; }
    static public Vector2 right { get; }
    static public Vector2 up { get; }
    static public Vector2 zero { get; }

    static public float Angle(Vector2 from, Vector2 to);
    static public Vector2 ClampMagnitude(Vector2 vector, float maxLength);
    static public float Distance(Vector2 a, Vector2 b);
    static public float Dot(Vector2 lhs, Vector2 rhs);
    static public Vector2 Lerp(Vector2 a, Vector2 b, float t);
    static public Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t);
    static public Vector2 Max(Vector2 lhs, Vector2 rhs);
    static public Vector2 Min(Vector2 lhs, Vector2 rhs);
    static public Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta);
    static public Vector2 Perpendicular(Vector2 inDirection);
    static public Vector2 Reflect(Vector2 inDirection, Vector2 inNormal);
    static public Vector2 Scale(Vector2 a, Vector2 b);
    static public float SignedAngle(Vector2 from, Vector2 to);
    static public Vector2 SmoothDamp(Vector2 current, Vector2 target, Vector2 currentVelocity, float smoothTime, float maxSpeed);
    static public Vector2 SmoothDamp(Vector2 current, Vector2 target, Vector2 currentVelocity, float smoothTime);
    static public Vector2 SmoothDamp(Vector2 current, Vector2 target, Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
    static public float SqrMagnitude(Vector2 a);

    public float x;
    public float y;

    public float this[int index] { get; set; }
    public float magnitude { get; }
    public Vector2 normalized { get; }
    public float sqrMagnitude { get; }

    public Vector2(float x, float y);

    public bool Equals(object other);
    public bool Equals(Vector2 other);
    public int GetHashCode();
    public void Normalize();
    public void Scale(Vector2 scale);
    public void Set(float newX, float newY);
    public float SqrMagnitude();
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
