using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public static class XRSettings
{
    static public Rendering.TextureDimension deviceEyeTextureDimension { get; }
    static public bool enabled { get; set; }
    static public RenderTextureDescriptor eyeTextureDesc { get; }
    static public int eyeTextureHeight { get; }
    static public float eyeTextureResolutionScale { get; set; }
    static public int eyeTextureWidth { get; }
    static public XR.GameViewRenderMode gameViewRenderMode { get; set; }
    static public bool isDeviceActive { get; }
    static public string loadedDeviceName { get; }
    static public float occlusionMaskScale { get; set; }
    static public float renderScale { get; set; }
    static public float renderViewportScale { get; set; }
    static public bool showDeviceView { get; set; }
    static public StereoRenderingMode stereoRenderingMode { get; }
    static public string[] supportedDevices { get; }
    static public bool useOcclusionMesh { get; set; }

    static public void LoadDeviceByName(string deviceName);
    static public void LoadDeviceByName(string[] prioritizedDeviceNameList);

    public enum StereoRenderingMode
    {
        MultiPass = 0,
        SinglePass = 1,
        SinglePassInstanced = 2,
        SinglePassMultiview = 3,
    }

}

}
