using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRDisplaySubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRDisplaySubsystemDescriptor>
{
    static public event Action<bool> displayFocusChanged;

    public bool singlePassRenderingDisabled { get; set; }

    public XRDisplaySubsystem();

}

}
