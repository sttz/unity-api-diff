using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRReferencePointSubsystem : IntegratedSubsystem<Experimental.XR.XRReferencePointSubsystemDescriptor>
{
    public int LastUpdatedFrame { get; }

    public event Action<Experimental.XR.ReferencePointUpdatedEventArgs> ReferencePointUpdated;

    public XRReferencePointSubsystem();

    public void GetAllReferencePoints(System.Collections.Generic.List<Experimental.XR.ReferencePoint> referencePointsOut);
    public bool TryAddReferencePoint(Vector3 position, Quaternion rotation, out Experimental.XR.TrackableId referencePointId);
    public bool TryAddReferencePoint(Pose pose, out Experimental.XR.TrackableId referencePointId);
    public bool TryGetReferencePoint(Experimental.XR.TrackableId referencePointId, out Experimental.XR.ReferencePoint referencePoint);
    public bool TryRemoveReferencePoint(Experimental.XR.TrackableId referencePointId);

}

}
