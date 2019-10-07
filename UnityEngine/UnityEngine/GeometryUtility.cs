using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GeometryUtility
{
    static public Bounds CalculateBounds(Vector3[] positions, Matrix4x4 transform);
    static public Plane[] CalculateFrustumPlanes(Camera camera);
    static public Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix);
    static public void CalculateFrustumPlanes(Camera camera, Plane[] planes);
    static public void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes);
    static public bool TestPlanesAABB(Plane[] planes, Bounds bounds);
    static public bool TryCreatePlaneFromPolygon(Vector3[] vertices, out Plane plane);

    public GeometryUtility();

}

}
