using System;
using UnityEngine;

namespace UnityEngine
{

public static class FrameTimingManager
{
    static public void CaptureFrameTimings();
    static public ulong GetCpuTimerFrequency();
    static public ulong GetGpuTimerFrequency();
    static public uint GetLatestTimings(uint numFrames, FrameTiming[] timings);
    static public float GetVSyncsPerSecond();

}

}
