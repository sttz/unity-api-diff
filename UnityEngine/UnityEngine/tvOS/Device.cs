using System;
using UnityEngine;

namespace UnityEngine.tvOS
{

public sealed class Device
{
    static public string advertisingIdentifier { get; }
    static public bool advertisingTrackingEnabled { get; }
    static public tvOS.DeviceGeneration generation { get; }
    static public string systemVersion { get; }
    static public string vendorIdentifier { get; }

    static public void ResetNoBackupFlag(string path);
    static public void SetNoBackupFlag(string path);

    public Device();

}

}
