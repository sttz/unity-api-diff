using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class SurfaceEffector2D : Effector2D
{
    public float forceScale { get; set; }
    public float speed { get; set; }
    public float speedVariation { get; set; }
    public bool useBounce { get; set; }
    public bool useContactForce { get; set; }
    public bool useFriction { get; set; }

    public SurfaceEffector2D();

}

}
