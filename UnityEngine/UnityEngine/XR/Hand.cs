using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct Hand : IEquatable<XR.Hand>
{
    public bool Equals(object obj);
    public bool Equals(XR.Hand other);
    public int GetHashCode();
    public bool TryGetFingerBones(XR.HandFinger finger, List<XR.Bone> bonesOut);
    public bool TryGetRootBone(out XR.Bone boneOut);

}

}
