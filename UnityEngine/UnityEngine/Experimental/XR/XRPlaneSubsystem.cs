using System;
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

    public void GetAllPlanes(System.Collections.Generic.List<Experimental.XR.BoundedPlane> planesOut);
    public bool TryGetPlane(Experimental.XR.TrackableId planeId, out Experimental.XR.BoundedPlane plane);
    public bool TryGetPlaneBoundary(Experimental.XR.TrackableId planeId, System.Collections.Generic.List<Vector3> boundaryOut);

}

}
