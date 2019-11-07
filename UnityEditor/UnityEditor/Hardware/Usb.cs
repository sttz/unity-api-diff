using System;
using UnityEngine;

namespace UnityEditor.Hardware
{

public sealed class Usb
{
    static public event OnDevicesChangedHandler DevicesChanged;

    static public void OnDevicesChanged(UnityEditor.Hardware.UsbDevice[] devices);

    public Usb();

    public delegate void OnDevicesChangedHandler(UnityEditor.Hardware.UsbDevice[] devices);

}

}
