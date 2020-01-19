using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public enum InputTrackingState : uint
{
    None = 0,
    Position = 1,
    Rotation = 2,
    Velocity = 4,
    AngularVelocity = 8,
    Acceleration = 16,
    AngularAcceleration = 32,
    All = 63,
}

}
