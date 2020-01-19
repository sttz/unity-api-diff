using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct InputDevice : IEquatable<XR.InputDevice>
{
    public bool IsValid { get; }

    public bool Equals(object obj);
    public bool Equals(XR.InputDevice other);
    public int GetHashCode();
    public bool SendHapticBuffer(uint channel, byte[] buffer);
    public bool SendHapticImpulse(uint channel, float amplitude, float duration = 1);
    public void StopHaptics();
    public bool TryGetHapticCapabilities(out XR.HapticCapabilities capabilities);

}

}
