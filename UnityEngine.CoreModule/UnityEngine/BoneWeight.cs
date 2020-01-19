using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct BoneWeight : IEquatable<BoneWeight>
{
    public int boneIndex0 { get; set; }
    public int boneIndex1 { get; set; }
    public int boneIndex2 { get; set; }
    public int boneIndex3 { get; set; }
    public float weight0 { get; set; }
    public float weight1 { get; set; }
    public float weight2 { get; set; }
    public float weight3 { get; set; }

    public bool Equals(object other);
    public bool Equals(BoneWeight other);
    public int GetHashCode();

}

}
