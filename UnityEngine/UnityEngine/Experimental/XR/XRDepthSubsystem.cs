using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDepthSubsystem : IntegratedSubsystem<Experimental.XR.XRDepthSubsystemDescriptor>
{
    public int LastUpdatedFrame { get; }

    public event Action<Experimental.XR.PointCloudUpdatedEventArgs> PointCloudUpdated;

    public XRDepthSubsystem();

    public void GetConfidence(System.Collections.Generic.List<float> confidenceOut);
    public void GetPoints(System.Collections.Generic.List<Vector3> pointsOut);

}

}
