using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Plane
{
    static public Plane Translate(Plane plane, Vector3 translation);

    public float distance { get; set; }
    public Plane flipped { get; }
    public Vector3 normal { get; set; }

    public Plane(Vector3 inNormal, float d);
    public Plane(Vector3 inNormal, Vector3 inPoint);
    public Plane(Vector3 a, Vector3 b, Vector3 c);

    public Vector3 ClosestPointOnPlane(Vector3 point);
    public void Flip();
    public float GetDistanceToPoint(Vector3 point);
    public bool GetSide(Vector3 point);
    public bool Raycast(Ray ray, out float enter);
    public bool SameSide(Vector3 inPt0, Vector3 inPt1);
    public void Set3Points(Vector3 a, Vector3 b, Vector3 c);
    public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint);
    public string ToString();
    public string ToString(string format);
    public void Translate(Vector3 translation);

}

}
