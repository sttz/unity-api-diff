using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct GestureRecognitionEvent
{
    public Experimental.XR.GestureEventState eventState { get; }
    public XR.InputDevice inputDevice { get; }
    public Pose pointerPose { get; }
    public DateTime time { get; }
    public Experimental.XR.GestureRecognitionValidFields validFields { get; }

}

}
