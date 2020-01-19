using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class XRInputSubsystem : IntegratedSubsystem<XR.XRInputSubsystemDescriptor>
{
    public event Action<XR.XRInputSubsystem> boundaryChanged;
    public event Action<XR.XRInputSubsystem> trackingOriginUpdated;

    public XRInputSubsystem();

    public XR.TrackingOriginModeFlags GetSupportedTrackingOriginModes();
    public XR.TrackingOriginModeFlags GetTrackingOriginMode();
    public bool TryGetBoundaryPoints(List<Vector3> boundaryPoints);
    public bool TryGetInputDevices(List<XR.InputDevice> devices);
    public bool TryRecenter();
    public bool TrySetTrackingOriginMode(XR.TrackingOriginModeFlags origin);

}

}
