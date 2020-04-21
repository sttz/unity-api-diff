using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XR.XRDisplaySubsystem>
{
    public bool disablesLegacyVr { get; }
    public bool enableBackBufferMSAA { get; }

    public XRDisplaySubsystemDescriptor();

    public int GetAvailableMirrorBlitModeCount();
    public void GetMirrorBlitModeByIndex(int index, out XR.XRMirrorViewBlitModeDesc mode);

}

}
