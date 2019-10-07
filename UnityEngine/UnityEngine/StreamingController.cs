using System;
using UnityEngine;

namespace UnityEngine
{

public class StreamingController : Behaviour
{
    public float streamingMipmapBias { get; set; }

    public StreamingController();

    public void CancelPreloading();
    public bool IsPreloading();
    public void SetPreloading(float timeoutSeconds = 0, bool activateCameraOnTimeout = false, Camera disableCameraCuttingFrom = null);

}

}
