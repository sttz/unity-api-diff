using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public enum GestureNavigationValidFields : uint
{
    None = 0,
    Time = 1,
    DeviceId = 2,
    GestureTrackingCoordinates = 4,
    NormalizedOffset = 8,
    PointerPose = 16,
}

}
