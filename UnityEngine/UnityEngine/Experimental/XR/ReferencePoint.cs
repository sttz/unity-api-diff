using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct ReferencePoint
{
    public Experimental.XR.TrackableId Id { get; internal set; }
    public Pose Pose { get; internal set; }
    public Experimental.XR.TrackingState TrackingState { get; internal set; }

}

}
