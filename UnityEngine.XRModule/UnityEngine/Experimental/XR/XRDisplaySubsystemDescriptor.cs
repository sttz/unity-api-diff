using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRDisplaySubsystem>
{
    public bool disablesLegacyVr { get; }

    public XRDisplaySubsystemDescriptor();

}

}
