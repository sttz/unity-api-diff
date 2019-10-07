using System;
using UnityEngine;

namespace UnityEngine.XR.WSA.WebCam
{

public struct CameraParameters
{
    public int cameraResolutionHeight { get; set; }
    public int cameraResolutionWidth { get; set; }
    public float frameRate { get; set; }
    public float hologramOpacity { get; set; }
    public XR.WSA.WebCam.CapturePixelFormat pixelFormat { get; set; }

    public CameraParameters(XR.WSA.WebCam.WebCamMode webCamMode);

}

}
