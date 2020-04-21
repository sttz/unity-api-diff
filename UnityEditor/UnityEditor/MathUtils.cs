using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class MathUtils
{
    static public bool ClosestPtRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, float t, Vector3 q);
    static public Vector3 ClosestPtSegmentRay(Vector3 p1, Vector3 q1, Ray ray, out float squaredDist, out float s, out Vector3 closestRay);
    static public float Ease(float t, float k1, float k2);
    static public Quaternion GetQuatConjugate(Quaternion q);
    static public Quaternion GetQuatExp(Quaternion q);
    static public float GetQuatLength(Quaternion q);
    static public Quaternion GetQuatLog(Quaternion q);
    static public Quaternion GetQuatSquad(float t, Quaternion q0, Quaternion q1, Quaternion a0, Quaternion a1);
    static public Quaternion GetSquadIntermediate(Quaternion q0, Quaternion q1, Quaternion q2);
    static public bool IntersectRaySphere(Ray ray, Vector3 sphereOrigin, float sphereRadius, float t, Vector3 q);
    static public object IntersectRayTriangle(Ray ray, Vector3 v0, Vector3 v1, Vector3 v2, bool bidirectional);
    static public Matrix4x4 OrthogonalizeMatrix(Matrix4x4 m);
    static public Quaternion QuaternionFromMatrix(Matrix4x4 m);
    static public void QuaternionNormalize(Quaternion q);
    static public Quaternion Slerp(Quaternion p, Quaternion q, float t);

    public MathUtils();

}

}
