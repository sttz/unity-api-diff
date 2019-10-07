using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDepthSubsystemDescriptor : Experimental.IntegratedSubsystemDescriptor<Experimental.XR.XRDepthSubsystem>
{
    public bool SupportsFeaturePoints { get; }

    public XRDepthSubsystemDescriptor();

}

}
