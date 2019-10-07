using System;
using UnityEngine;

namespace UnityEngine
{

public struct ClothSphereColliderPair
{
    public SphereCollider first { get; set; }
    public SphereCollider second { get; set; }

    public ClothSphereColliderPair(SphereCollider a);
    public ClothSphereColliderPair(SphereCollider a, SphereCollider b);

}

}
