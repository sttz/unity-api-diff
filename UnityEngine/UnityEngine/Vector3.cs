using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Vector3 : IEquatable<Vector3>
{
    static public float kEpsilon = 1E-05;
    static public float kEpsilonNormalSqrt = 1E-15;

    static public Vector3 back { get; }
    static public Vector3 down { get; }
    static public Vector3 forward { get; }
    static public Vector3 fwd { get; }
    static public Vector3 left { get; }
    static public Vector3 negativeInfinity { get; }
    static public Vector3 one { get; }
    static public Vector3 positiveInfinity { get; }
    static public Vector3 right { get; }
    static public Vector3 up { get; }
    static public Vector3 zero { get; }

    static public float Angle(Vector3 from, Vector3 to);
    static public float AngleBetween(Vector3 from, Vector3 to);
    static public Vector3 ClampMagnitude(Vector3 vector, float maxLength);
    static public Vector3 Cross(Vector3 lhs, Vector3 rhs);
    static public float Distance(Vector3 a, Vector3 b);
    static public float Dot(Vector3 lhs, Vector3 rhs);
    static public Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat);
    static public Vector3 Lerp(Vector3 a, Vector3 b, float t);
    static public Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t);
    static public float Magnitude(Vector3 vector);
    static public Vector3 Max(Vector3 lhs, Vector3 rhs);
    static public Vector3 Min(Vector3 lhs, Vector3 rhs);
    static public Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta);
    static public Vector3 Normalize(Vector3 value);
    static public void OrthoNormalize(Vector3 normal, Vector3 tangent);
    static public void OrthoNormalize(Vector3 normal, Vector3 tangent, Vector3 binormal);
    static public Vector3 Project(Vector3 vector, Vector3 onNormal);
    static public Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal);
    static public Vector3 Reflect(Vector3 inDirection, Vector3 inNormal);
    static public Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta);
    static public Vector3 Scale(Vector3 a, Vector3 b);
    static public float SignedAngle(Vector3 from, Vector3 to, Vector3 axis);
    static public Vector3 Slerp(Vector3 a, Vector3 b, float t);
    static public Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t);
    static public Vector3 SmoothDamp(Vector3 current, Vector3 target, Vector3 currentVelocity, float smoothTime);
    static public Vector3 SmoothDamp(Vector3 current, Vector3 target, Vector3 currentVelocity, float smoothTime, float maxSpeed);
    static public Vector3 SmoothDamp(Vector3 current, Vector3 target, Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
    static public float SqrMagnitude(Vector3 vector);

    public float x;
    public float y;
    public float z;

    public float this[int index] { get; set; }
    public float magnitude { get; }
    public Vector3 normalized { get; }
    public float sqrMagnitude { get; }

    public Vector3(float x, float y);
    public Vector3(float x, float y, float z);

    public bool Equals(object other);
    public bool Equals(Vector3 other);
    public int GetHashCode();
    public void Normalize();
    public void Scale(Vector3 scale);
    public void Set(float newX, float newY, float newZ);
    public string ToString();
    public string ToString(string format);

}

}
