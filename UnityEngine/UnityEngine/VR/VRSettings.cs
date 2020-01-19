using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.VR
{

public static class VRSettings
{
    static public bool enabled { get; set; }
    static public int eyeTextureHeight { get; }
    static public int eyeTextureWidth { get; }
    static public bool isDeviceActive { get; }
    static public VR.VRDeviceType loadedDevice { get; set; }
    static public string loadedDeviceName { get; }
    static public float occlusionMaskScale { get; set; }
    static public float renderScale { get; set; }
    static public float renderViewportScale { get; set; }
    static public bool showDeviceView { get; set; }
    static public string[] supportedDevices { get; }

    static public void LoadDeviceByName(string deviceName);
    static public void LoadDeviceByName(string[] prioritizedDeviceNameList);

}

}
