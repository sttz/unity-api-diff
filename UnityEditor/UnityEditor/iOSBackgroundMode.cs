using System;
using UnityEngine;

namespace UnityEditor
{

public enum iOSBackgroundMode : uint
{
    None = 0,
    Audio = 1,
    Location = 2,
    VOIP = 4,
    NewsstandContent = 8,
    ExternalAccessory = 16,
    BluetoothCentral = 32,
    BluetoothPeripheral = 64,
    Fetch = 128,
    RemoteNotification = 256,
}

}
