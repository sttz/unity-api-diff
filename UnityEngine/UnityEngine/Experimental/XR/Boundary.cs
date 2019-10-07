using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public static class Boundary
{
    static public bool configured { get; }
    static public bool visible { get; set; }

    static public bool TryGetDimensions(out Vector3 dimensionsOut);
    static public bool TryGetDimensions(out Vector3 dimensionsOut, Type boundaryType);
    static public bool TryGetGeometry(System.Collections.Generic.List<Vector3> geometry);
    static public bool TryGetGeometry(System.Collections.Generic.List<Vector3> geometry, Type boundaryType);

    public enum Type
    {
        PlayArea = 0,
        TrackedArea = 1,
    }

}

}
