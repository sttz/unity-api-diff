using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct Eyes : IEquatable<XR.Eyes>
{
    public bool Equals(object obj);
    public bool Equals(XR.Eyes other);
    public int GetHashCode();
    public bool TryGetFixationPoint(out Vector3 fixationPoint);
    public bool TryGetLeftEyeOpenAmount(out float openAmount);
    public bool TryGetLeftEyePosition(out Vector3 position);
    public bool TryGetLeftEyeRotation(out Quaternion rotation);
    public bool TryGetRightEyeOpenAmount(out float openAmount);
    public bool TryGetRightEyePosition(out Vector3 position);
    public bool TryGetRightEyeRotation(out Quaternion rotation);

}

}
