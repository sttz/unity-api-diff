using System;
using UnityEngine;

namespace UnityEngine
{

public struct BoneWeight1 : IEquatable<BoneWeight1>
{
    public int boneIndex { get; set; }
    public float weight { get; set; }

    public bool Equals(object other);
    public bool Equals(BoneWeight1 other);
    public int GetHashCode();

}

}
