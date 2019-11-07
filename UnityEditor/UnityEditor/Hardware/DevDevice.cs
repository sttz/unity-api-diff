using System;
using UnityEngine;

namespace UnityEditor.Hardware
{

public struct DevDevice
{
    static public UnityEditor.Hardware.DevDevice none { get; }

    public UnityEditor.Hardware.DevDeviceFeatures features;
    public string id;
    public string module;
    public string name;
    public UnityEditor.Hardware.DevDeviceState state;
    public string type;

    public bool isConnected { get; }

    public DevDevice(string id, string name, string type, string module, UnityEditor.Hardware.DevDeviceState state, UnityEditor.Hardware.DevDeviceFeatures features);

    public string ToString();

}

}
