using System;
using UnityEngine;

namespace UnityEditor.Hardware
{

public struct UsbDevice
{
    public string name;
    public int productId;
    public int revision;
    public string udid;
    public int vendorId;

    public string ToString();

}

}
