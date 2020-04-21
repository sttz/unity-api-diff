using System;
using System.Collections;
using System.Collections.Generic;
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
