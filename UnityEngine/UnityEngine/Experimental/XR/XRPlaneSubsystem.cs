using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRPlaneSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRPlaneSubsystemDescriptor>
{
    public int LastUpdatedFrame { get; }

    public event Action<Experimental.XR.PlaneAddedEventArgs> PlaneAdded;
    public event Action<Experimental.XR.PlaneRemovedEventArgs> PlaneRemoved;
    public event Action<Experimental.XR.PlaneUpdatedEventArgs> PlaneUpdated;

    public XRPlaneSubsystem();

    public void GetAllPlanes(List<Experimental.XR.BoundedPlane> planesOut);
    public bool TryGetPlane(Experimental.XR.TrackableId planeId, out Experimental.XR.BoundedPlane plane);
    public bool TryGetPlaneBoundary(Experimental.XR.TrackableId planeId, List<Vector3> boundaryOut);

}

}
