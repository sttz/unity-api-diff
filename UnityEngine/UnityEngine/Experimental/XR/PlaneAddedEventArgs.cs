using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct PlaneAddedEventArgs
{
    public Experimental.XR.BoundedPlane Plane { get; internal set; }
    public Experimental.XR.XRPlaneSubsystem PlaneSubsystem { get; internal set; }

}

}
