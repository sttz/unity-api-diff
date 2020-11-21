using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XR.XRInputSubsystem>
{
    public bool disablesLegacyInput { get; }

    public XRInputSubsystemDescriptor();

}

}
