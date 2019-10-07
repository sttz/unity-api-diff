using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct GestureNavigationEvent
{
    public Experimental.XR.GestureEventState eventState { get; }
    public Experimental.XR.GestureTrackingCoordinates gestureTrackingCoordinates { get; }
    public XR.InputDevice inputDevice { get; }
    public Vector3 normalizedOffset { get; }
    public Pose pointerPose { get; }
    public DateTime time { get; }
    public Experimental.XR.GestureNavigationValidFields validFields { get; }

}

}
