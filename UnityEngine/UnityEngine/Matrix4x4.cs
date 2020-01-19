using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Matrix4x4 : IEquatable<Matrix4x4>
{
    static public Matrix4x4 identity { get; }
    static public Matrix4x4 zero { get; }

    static public float Determinant(Matrix4x4 m);
    static public Matrix4x4 Frustum(FrustumPlanes fp);
    static public Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar);
    static public Matrix4x4 Inverse(Matrix4x4 m);
    static public Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up);
    static public Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
    static public Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
    static public Matrix4x4 Rotate(Quaternion q);
    static public Matrix4x4 Scale(Vector3 vector);
    static public Matrix4x4 Translate(Vector3 vector);
    static public Matrix4x4 Transpose(Matrix4x4 m);
    static public Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s);

    public float m00;
    public float m01;
    public float m02;
    public float m03;
    public float m10;
    public float m11;
    public float m12;
    public float m13;
    public float m20;
    public float m21;
    public float m22;
    public float m23;
    public float m30;
    public float m31;
    public float m32;
    public float m33;

    public FrustumPlanes decomposeProjection { get; }
    public float determinant { get; }
    public Matrix4x4 inverse { get; }
    public bool isIdentity { get; }
    public float this[int row, int column] { get; set; }
    public float this[int index] { get; set; }
    public Vector3 lossyScale { get; }
    public Quaternion rotation { get; }
    public Matrix4x4 transpose { get; }

    public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3);

    public bool Equals(object other);
    public bool Equals(Matrix4x4 other);
    public Vector4 GetColumn(int index);
    public int GetHashCode();
    public Vector4 GetRow(int index);
    public Vector3 MultiplyPoint(Vector3 point);
    public Vector3 MultiplyPoint3x4(Vector3 point);
    public Vector3 MultiplyVector(Vector3 vector);
    public void SetColumn(int index, Vector4 column);
    public void SetRow(int index, Vector4 row);
    public void SetTRS(Vector3 pos, Quaternion q, Vector3 s);
    public string ToString();
    public string ToString(string format);
    public Plane TransformPlane(Plane plane);
    public bool ValidTRS();

}

}
