using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRDisplaySubsystem>
{
    public bool disablesLegacyVr { get; }

    public XRDisplaySubsystemDescriptor();

}

}
