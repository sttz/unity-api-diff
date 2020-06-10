using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Hardware
{

public sealed class DevDeviceList
{
    static public event OnChangedHandler Changed;

    static public bool FindDevice(string deviceId, out UnityEditor.Hardware.DevDevice device);
    static public UnityEditor.Hardware.DevDevice[] GetDevices();
    static public void OnChanged();

    public DevDeviceList();

    public delegate void OnChangedHandler();

}

}
