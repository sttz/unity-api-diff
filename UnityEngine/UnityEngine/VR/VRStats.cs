using System;
using UnityEngine;

namespace UnityEngine.VR
{

public static class VRStats
{
    static public float gpuTimeLastFrame { get; }

    static public bool TryGetDroppedFrameCount(out int droppedFrameCount);
    static public bool TryGetFramePresentCount(out int framePresentCount);
    static public bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame);

}

}
