using System;
using UnityEngine;

namespace UnityEngine
{

public struct FrameTiming
{
    public double cpuFrameTime;
    public ulong cpuTimeFrameComplete;
    public ulong cpuTimePresentCalled;
    public double gpuFrameTime;
    public float heightScale;
    public uint syncInterval;
    public float widthScale;

}

}
