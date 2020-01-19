using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public class HolographicRemoting
{
    static public XR.WSA.HolographicStreamerConnectionState ConnectionState { get; }

    static public void Connect(string clientName, int maxBitRate = 9999);
    static public void Connect(string clientName, int maxBitRate, XR.WSA.RemoteDeviceVersion deviceVersion);
    static public void Disconnect();

    public HolographicRemoting();

}

}
