using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct GestureHoldEvent
{
    public Experimental.XR.GestureEventState eventState { get; }
    public XR.InputDevice inputDevice { get; }
    public Pose pointerPose { get; }
    public DateTime time { get; }
    public Experimental.XR.GestureHoldValidFields validFields { get; }

}

}
