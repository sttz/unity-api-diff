using System;
using UnityEngine;

namespace UnityEngine.Windows.WebCam
{

public struct CameraParameters
{
    public int cameraResolutionHeight { get; set; }
    public int cameraResolutionWidth { get; set; }
    public float frameRate { get; set; }
    public float hologramOpacity { get; set; }
    public Windows.WebCam.CapturePixelFormat pixelFormat { get; set; }

    public CameraParameters(Windows.WebCam.WebCamMode webCamMode);

}

}
