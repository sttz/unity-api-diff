using System;
using UnityEngine;

namespace UnityEngine.XR
{

public struct InputDevice : IEquatable<XR.InputDevice>
{
    public bool isValid { get; }
    public string name { get; }
    public XR.InputDeviceRole role { get; }

    public bool Equals(object obj);
    public bool Equals(XR.InputDevice other);
    public int GetHashCode();
    public bool SendHapticBuffer(uint channel, byte[] buffer);
    public bool SendHapticImpulse(uint channel, float amplitude, float duration = 1);
    public void StopHaptics();
    public bool TryGetFeatureUsages(System.Collections.Generic.List<XR.InputFeatureUsage> featureUsages);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<bool> usage, out bool value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<uint> usage, out uint value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<float> usage, out float value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<Vector2> usage, out Vector2 value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<Vector3> usage, out Vector3 value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<Quaternion> usage, out Quaternion value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<XR.Hand> usage, out XR.Hand value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<XR.Bone> usage, out XR.Bone value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<XR.Eyes> usage, out XR.Eyes value);
    public bool TryGetFeatureValue(XR.InputFeatureUsage<XR.InputTrackingState> usage, out XR.InputTrackingState value);
    public bool TryGetHapticCapabilities(out XR.HapticCapabilities capabilities);

}

}
