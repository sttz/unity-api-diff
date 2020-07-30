using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public static class XRDevice
{
    static public float fovZoomFactor { get; set; }
    static public bool isPresent { get; }
    static public float refreshRate { get; }

    static public event Action<string> deviceLoaded;

    static public void DisableAutoXRCameraTracking(Camera camera, bool disabled);
    static public IntPtr GetNativePtr();
    static public XR.TrackingSpaceType GetTrackingSpaceType();
    static public bool SetTrackingSpaceType(XR.TrackingSpaceType trackingSpaceType);
    static public void UpdateEyeTextureMSAASetting();

}

}
