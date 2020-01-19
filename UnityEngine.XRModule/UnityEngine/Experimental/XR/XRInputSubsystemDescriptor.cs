using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRInputSubsystemDescriptor : Experimental.IntegratedSubsystemDescriptor<Experimental.XR.XRInputSubsystem>
{
    public bool disablesLegacyInput { get; }

    public XRInputSubsystemDescriptor();

}

}
