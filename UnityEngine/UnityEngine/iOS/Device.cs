using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.iOS
{

public sealed class Device
{
    static public string advertisingIdentifier { get; }
    static public bool advertisingTrackingEnabled { get; }
    static public iOS.SystemGestureDeferMode deferSystemGesturesMode { get; set; }
    static public iOS.DeviceGeneration generation { get; }
    static public bool hideHomeButton { get; set; }
    static public string systemVersion { get; }
    static public string vendorIdentifier { get; }

    static public bool RequestStoreReview();
    static public void ResetNoBackupFlag(string path);
    static public void SetNoBackupFlag(string path);

    public Device();

}

}
