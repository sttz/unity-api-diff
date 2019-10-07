using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class iPhone
{
    static public string advertisingIdentifier { get; }
    static public bool advertisingTrackingEnabled { get; }
    static public iPhoneGeneration generation { get; }
    static public string vendorIdentifier { get; }

    static public void ResetNoBackupFlag(string path);
    static public void SetNoBackupFlag(string path);

    public iPhone();

}

}
