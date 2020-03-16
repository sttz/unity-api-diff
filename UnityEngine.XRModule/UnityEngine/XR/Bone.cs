using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct Bone : IEquatable<XR.Bone>
{
    public bool Equals(object obj);
    public bool Equals(XR.Bone other);
    public int GetHashCode();
    public bool TryGetChildBones(List<XR.Bone> childBones);
    public bool TryGetParentBone(out XR.Bone parentBone);
    public bool TryGetPosition(out Vector3 position);
    public bool TryGetRotation(out Quaternion rotation);

}

}