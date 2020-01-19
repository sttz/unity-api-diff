using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling
{

public sealed class Profiler
{
    static public int areaCount { get; }
    static public bool enableBinaryLog { get; set; }
    static public bool enabled { get; set; }
    static public string logFile { get; set; }
    static public int maxNumberOfSamplesPerFrame { get; set; }
    static public int maxUsedMemory { get; set; }
    static public bool supported { get; }
    static public uint usedHeapSize { get; }
    static public long usedHeapSizeLong { get; }

    static public void AddFramesFromFile(string file);
    static public void BeginSample(string name);
    static public void BeginSample(string name, Object targetObject);
    static public void BeginThreadProfiling(string threadGroupName, string threadName);
    static public void EndSample();
    static public void EndThreadProfiling();
    static public long GetAllocatedMemoryForGraphicsDriver();
    static public bool GetAreaEnabled(Profiling.ProfilerArea area);
    static public uint GetMonoHeapSize();
    static public long GetMonoHeapSizeLong();
    static public uint GetMonoUsedSize();
    static public long GetMonoUsedSizeLong();
    static public int GetRuntimeMemorySize(Object o);
    static public long GetRuntimeMemorySizeLong(Object o);
    static public uint GetTempAllocatorSize();
    static public uint GetTotalAllocatedMemory();
    static public long GetTotalAllocatedMemoryLong();
    static public uint GetTotalReservedMemory();
    static public long GetTotalReservedMemoryLong();
    static public uint GetTotalUnusedReservedMemory();
    static public long GetTotalUnusedReservedMemoryLong();
    static public void SetAreaEnabled(Profiling.ProfilerArea area, bool enabled);
    static public bool SetTempAllocatorRequestedSize(uint size);

}

}
