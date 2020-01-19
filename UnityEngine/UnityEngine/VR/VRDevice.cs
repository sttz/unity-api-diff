using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VR
{

public static class VRDevice
{
    static public string family { get; }
    static public bool isPresent { get; }
    static public string model { get; }
    static public float refreshRate { get; }
    static public XR.UserPresenceState userPresence { get; }

    static public void DisableAutoVRCameraTracking(Camera camera, bool disabled);
    static public IntPtr GetNativePtr();
    static public XR.TrackingSpaceType GetTrackingSpaceType();
    static public bool SetTrackingSpaceType(XR.TrackingSpaceType trackingSpaceType);

}

}
