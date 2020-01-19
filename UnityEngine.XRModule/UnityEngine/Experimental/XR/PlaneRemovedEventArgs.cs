using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct PlaneRemovedEventArgs
{
    public Experimental.XR.BoundedPlane Plane { get; internal set; }
    public Experimental.XR.XRPlaneSubsystem PlaneSubsystem { get; internal set; }

}

}
