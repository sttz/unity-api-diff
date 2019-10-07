using System;
using UnityEngine;

namespace UnityEngine
{

public struct WheelHit
{
    public Collider collider { get; set; }
    public float force { get; set; }
    public Vector3 forwardDir { get; set; }
    public float forwardSlip { get; set; }
    public Vector3 normal { get; set; }
    public Vector3 point { get; set; }
    public Vector3 sidewaysDir { get; set; }
    public float sidewaysSlip { get; set; }

}

}
