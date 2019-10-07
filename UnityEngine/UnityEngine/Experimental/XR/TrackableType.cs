using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public enum TrackableType
{
    None = 0,
    PlaneWithinPolygon = 1,
    PlaneWithinBounds = 2,
    PlaneWithinInfinity = 4,
    PlaneEstimated = 8,
    Planes = 15,
    FeaturePoint = 16,
    All = 31,
}

}
