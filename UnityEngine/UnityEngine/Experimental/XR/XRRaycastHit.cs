using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct XRRaycastHit
{
    public float Distance { get; set; }
    public Experimental.XR.TrackableType HitType { get; set; }
    public Pose Pose { get; set; }
    public Experimental.XR.TrackableId TrackableId { get; set; }

}

}
