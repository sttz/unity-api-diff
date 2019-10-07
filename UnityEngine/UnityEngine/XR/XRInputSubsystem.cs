using System;
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
    public bool TryGetBoundaryPoints(System.Collections.Generic.List<Vector3> boundaryPoints);
    public bool TryGetInputDevices(System.Collections.Generic.List<XR.InputDevice> devices);
    public bool TryRecenter();
    public bool TrySetTrackingOriginMode(XR.TrackingOriginModeFlags origin);

}

}
