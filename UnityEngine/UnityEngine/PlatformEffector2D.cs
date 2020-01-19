using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class PlatformEffector2D : Effector2D
{
    public bool oneWay { get; set; }
    public float rotationalOffset { get; set; }
    public float sideAngleVariance { get; set; }
    public float sideArc { get; set; }
    public bool sideBounce { get; set; }
    public bool sideFriction { get; set; }
    public float surfaceArc { get; set; }
    public bool useOneWay { get; set; }
    public bool useOneWayGrouping { get; set; }
    public bool useSideBounce { get; set; }
    public bool useSideFriction { get; set; }

    public PlatformEffector2D();

}

}
