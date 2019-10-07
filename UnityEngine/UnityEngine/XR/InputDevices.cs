using System;
using UnityEngine;

namespace UnityEngine.XR
{

public class InputDevices
{
    static public event Action<XR.InputDevice> deviceConnected;
    static public event Action<XR.InputDevice> deviceDisconnected;

    static public XR.InputDevice GetDeviceAtXRNode(XR.XRNode node);
    static public void GetDevices(System.Collections.Generic.List<XR.InputDevice> inputDevices);
    static public void GetDevicesAtXRNode(XR.XRNode node, System.Collections.Generic.List<XR.InputDevice> inputDevices);
    static public void GetDevicesWithRole(XR.InputDeviceRole role, System.Collections.Generic.List<XR.InputDevice> inputDevices);

    public InputDevices();

}

}
