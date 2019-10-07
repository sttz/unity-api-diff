using System;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public static class VFXManager
{
    static public float fixedTimeStep { get; set; }
    static public float maxDeltaTime { get; set; }

    static public Experimental.VFX.VisualEffect[] GetComponents();

}

}
