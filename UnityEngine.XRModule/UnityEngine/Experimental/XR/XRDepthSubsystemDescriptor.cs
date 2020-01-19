using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDepthSubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRDepthSubsystem>
{
    public bool SupportsFeaturePoints { get; }

    public XRDepthSubsystemDescriptor();

}

}
