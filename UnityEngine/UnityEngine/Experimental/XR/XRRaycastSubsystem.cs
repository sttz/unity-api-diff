using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRRaycastSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRRaycastSubsystemDescriptor>
{
    static public void Raycast(Ray ray, Experimental.XR.XRDepthSubsystem depthSubsystem, Experimental.XR.XRPlaneSubsystem planeSubsystem, System.Collections.Generic.List<Experimental.XR.XRRaycastHit> hitResults, Experimental.XR.TrackableType trackableTypeMask = 31, float pointCloudRaycastAngleInDegrees = 5);

    public XRRaycastSubsystem();

    public bool Raycast(Vector3 screenPoint, System.Collections.Generic.List<Experimental.XR.XRRaycastHit> hitResults, Experimental.XR.TrackableType trackableTypeMask = 31);

}

}
