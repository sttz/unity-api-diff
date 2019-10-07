using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct GestureTappedEvent
{
    public Experimental.XR.GestureEventState eventState { get; }
    public XR.InputDevice inputDevice { get; }
    public Pose pointerPose { get; }
    public uint tappedCount { get; }
    public DateTime time { get; }
    public Experimental.XR.GestureTappedValidFields validFields { get; }

}

}
