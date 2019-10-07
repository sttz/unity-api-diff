using System;
using UnityEngine;

namespace UnityEngine.XR
{

public enum InputDeviceCharacteristics : uint
{
    None = 0,
    HeadMounted = 1,
    Camera = 2,
    HeldInHand = 4,
    HandTracking = 8,
    EyeTracking = 16,
    TrackedDevice = 32,
    Controller = 64,
    TrackingReference = 128,
    Left = 256,
    Right = 512,
    Simulated6DOF = 1024,
}

}
