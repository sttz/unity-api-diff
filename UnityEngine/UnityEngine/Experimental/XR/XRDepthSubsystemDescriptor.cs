using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDepthSubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRDepthSubsystem>
{
    public bool SupportsFeaturePoints { get; }

    public XRDepthSubsystemDescriptor();

}

}
