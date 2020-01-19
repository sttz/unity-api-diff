using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct GestureManipulationEvent
{
    public Experimental.XR.GestureEventState eventState { get; }
    public XR.InputDevice inputDevice { get; }
    public Pose pointerPose { get; }
    public DateTime time { get; }
    public Vector3 translation { get; }
    public Experimental.XR.GestureManipulationValidFields validFields { get; }

}

}
