using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling
{

public struct ProfilerRecorder : IDisposable
{
    static public Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerMarker marker, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    static public Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory category, string statName, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);

    public int Capacity { get; }
    public int Count { get; }
    public long CurrentValue { get; }
    public double CurrentValueAsDouble { get; }
    public Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType { get; }
    public bool IsRunning { get; }
    public long LastValue { get; }
    public double LastValueAsDouble { get; }
    public Unity.Profiling.ProfilerMarkerDataUnit UnitType { get; }
    public bool Valid { get; }
    public bool WrappedAround { get; }

    public ProfilerRecorder(Unity.Profiling.ProfilerMarker marker, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    public ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    public ProfilerRecorder(string statName, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    public ProfilerRecorder(Unity.Profiling.ProfilerCategory category, string statName, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    public ProfilerRecorder(string categoryName, string statName, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);
    public ProfilerRecorder(Unity.Profiling.ProfilerCategory category, char statName, int statNameLen, int capacity = 1, Unity.Profiling.ProfilerRecorderOptions options = 24);

    public void CopyTo(List<Unity.Profiling.ProfilerRecorderSample> outSamples, bool reset = false);
    public int CopyTo(Unity.Profiling.ProfilerRecorderSample dest, int destSize, bool reset = false);
    public void Dispose();
    public Unity.Profiling.ProfilerRecorderSample GetSample(int index);
    public void Reset();
    public void Start();
    public void Stop();
    public Unity.Profiling.ProfilerRecorderSample[] ToArray();

}

}
