using System;
using UnityEngine;

namespace UnityEngine
{

public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
    static public float kEpsilon = 1E-06;

    static public Quaternion identity { get; }

    static public float Angle(Quaternion a, Quaternion b);
    static public Quaternion AngleAxis(float angle, Vector3 axis);
    static public Quaternion AxisAngle(Vector3 axis, float angle);
    static public float Dot(Quaternion a, Quaternion b);
    static public Quaternion Euler(float x, float y, float z);
    static public Quaternion Euler(Vector3 euler);
    static public Quaternion EulerAngles(float x, float y, float z);
    static public Quaternion EulerAngles(Vector3 euler);
    static public Quaternion EulerRotation(float x, float y, float z);
    static public Quaternion EulerRotation(Vector3 euler);
    static public Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection);
    static public Quaternion Inverse(Quaternion rotation);
    static public Quaternion Lerp(Quaternion a, Quaternion b, float t);
    static public Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t);
    static public Quaternion LookRotation(Vector3 forward, Vector3 upwards);
    static public Quaternion LookRotation(Vector3 forward);
    static public Quaternion Normalize(Quaternion q);
    static public Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta);
    static public Quaternion Slerp(Quaternion a, Quaternion b, float t);
    static public Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t);
    static public Vector3 ToEulerAngles(Quaternion rotation);

    public float w;
    public float x;
    public float y;
    public float z;

    public Vector3 eulerAngles { get; set; }
    public float this[int index] { get; set; }
    public Quaternion normalized { get; }

    public Quaternion(float x, float y, float z, float w);

    public bool Equals(object other);
    public bool Equals(Quaternion other);
    public int GetHashCode();
    public void Normalize();
    public void Set(float newX, float newY, float newZ, float newW);
    public void SetAxisAngle(Vector3 axis, float angle);
    public void SetEulerAngles(float x, float y, float z);
    public void SetEulerAngles(Vector3 euler);
    public void SetEulerRotation(float x, float y, float z);
    public void SetEulerRotation(Vector3 euler);
    public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection);
    public void SetLookRotation(Vector3 view);
    public void SetLookRotation(Vector3 view, Vector3 up);
    public void ToAngleAxis(out float angle, out Vector3 axis);
    public void ToAxisAngle(out Vector3 axis, out float angle);
    public Vector3 ToEuler();
    public Vector3 ToEulerAngles();
    public string ToString();
    public string ToString(string format);
    public string ToString(string format, IFormatProvider formatProvider);

}

}
