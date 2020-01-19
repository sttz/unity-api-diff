using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDepthSubsystem : IntegratedSubsystem<Experimental.XR.XRDepthSubsystemDescriptor>
{
    public int LastUpdatedFrame { get; }

    public event Action<Experimental.XR.PointCloudUpdatedEventArgs> PointCloudUpdated;

    public XRDepthSubsystem();

    public void GetConfidence(List<float> confidenceOut);
    public void GetPoints(List<Vector3> pointsOut);

}

}
