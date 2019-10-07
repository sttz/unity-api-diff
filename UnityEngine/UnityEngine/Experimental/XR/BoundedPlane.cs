using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct BoundedPlane
{
    public Experimental.XR.PlaneAlignment Alignment { get; set; }
    public Vector3 Center { get; set; }
    public float Height { get; }
    public Experimental.XR.TrackableId Id { get; set; }
    public Vector3 Normal { get; }
    public Plane Plane { get; }
    public Pose Pose { get; set; }
    public Vector2 Size { get; set; }
    public Experimental.XR.TrackableId SubsumedById { get; set; }
    public float Width { get; }

    public void GetCorners(out Vector3 p0, out Vector3 p1, out Vector3 p2, out Vector3 p3);
    public bool TryGetBoundary(System.Collections.Generic.List<Vector3> boundaryOut);

}

}
