using System;
using UnityEngine;

namespace UnityEngine.XR
{

public static class XRDevice
{
    static public string family { get; }
    static public float fovZoomFactor { get; set; }
    static public bool isPresent { get; }
    static public string model { get; }
    static public float refreshRate { get; }
    static public XR.TrackingOriginMode trackingOriginMode { get; }
    static public XR.UserPresenceState userPresence { get; }

    static public event Action<string> deviceLoaded;

    static public void DisableAutoXRCameraTracking(Camera camera, bool disabled);
    static public IntPtr GetNativePtr();
    static public XR.TrackingSpaceType GetTrackingSpaceType();
    static public bool SetTrackingSpaceType(XR.TrackingSpaceType trackingSpaceType);
    static public void UpdateEyeTextureMSAASetting();

}

}
