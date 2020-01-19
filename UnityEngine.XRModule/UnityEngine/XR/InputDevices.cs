using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class InputDevices
{
    static public event Action<XR.InputDevice> deviceConnected;
    static public event Action<XR.InputDevice> deviceDisconnected;

    static public XR.InputDevice GetDeviceAtXRNode(XR.XRNode node);
    static public void GetDevices(List<XR.InputDevice> inputDevices);
    static public void GetDevicesAtXRNode(XR.XRNode node, List<XR.InputDevice> inputDevices);
    static public void GetDevicesWithRole(XR.InputDeviceRole role, List<XR.InputDevice> inputDevices);

    public InputDevices();

}

}
