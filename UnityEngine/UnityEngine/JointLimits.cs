using System;
using UnityEngine;

namespace UnityEngine
{

public struct JointLimits
{
    public float maxBounce;
    public float minBounce;

    public float bounceMinVelocity { get; set; }
    public float bounciness { get; set; }
    public float contactDistance { get; set; }
    public float max { get; set; }
    public float min { get; set; }

}

}
