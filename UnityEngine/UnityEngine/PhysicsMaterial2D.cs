using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class PhysicsMaterial2D : Object
{
    public float bounciness { get; set; }
    public float friction { get; set; }

    public PhysicsMaterial2D();
    public PhysicsMaterial2D(string name);

}

}
