using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public static class XRStats
{
    static public bool TryGetDroppedFrameCount(out int droppedFrameCount);
    static public bool TryGetFramePresentCount(out int framePresentCount);
    static public bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame);

}

}
