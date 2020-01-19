using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct WebCamDevice
{
    public Resolution[] availableResolutions { get; }
    public string depthCameraName { get; }
    public bool isAutoFocusPointSupported { get; }
    public bool isFrontFacing { get; }
    public WebCamKind kind { get; }
    public string name { get; }

}

}
