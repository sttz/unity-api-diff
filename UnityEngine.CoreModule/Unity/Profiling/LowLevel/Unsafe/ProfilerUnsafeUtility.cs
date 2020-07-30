using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{

public static class ProfilerUnsafeUtility
{
    static public ushort CategoryAi = 7;
    static public ushort CategoryAllocation = 23;
    static public ushort CategoryAnimation = 6;
    static public ushort CategoryAudio = 8;
    static public ushort CategoryGUI = 4;
    static public ushort CategoryInput = 30;
    static public ushort CategoryInternal = 24;
    static public ushort CategoryLighting = 13;
    static public ushort CategoryLightning = 13;
    static public ushort CategoryLoading = 15;
    static public ushort CategoryNetwork = 14;
    static public ushort CategoryOther = 16;
    static public ushort CategoryParticles = 12;
    static public ushort CategoryPhysics = 5;
    static public ushort CategoryRender = 0;
    static public ushort CategoryScripts = 1;
    static public ushort CategoryVideo = 11;
    static public ushort CategoryVr = 22;

    static public long Timestamp { get; }
    static public TimestampConversionRatio TimestampToNanosecondsConversionRatio { get; }

    static public void BeginSample(IntPtr markerPtr);
    static public void BeginSampleWithMetadata(IntPtr markerPtr, int metadataCount, void metadata);
    static public void CreateCounterValue(out IntPtr counterPtr, string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
    static public void CreateCounterValue(out IntPtr counterPtr, char name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
    static public uint CreateFlow(ushort categoryId);
    static public IntPtr CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
    static public IntPtr CreateMarker(char name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
    static public void EndSample(IntPtr markerPtr);
    static public void FlowEvent(uint flowId, Unity.Profiling.ProfilerFlowEventType flowEventType);
    static public void FlushCounterValue(void counterValuePtr);
    static public ushort GetCategoryByName(char name, int nameLen);
    static public Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
    static public void SetMarkerMetadata(IntPtr markerPtr, int index, string name, byte type, byte unit);
    static public void SetMarkerMetadata(IntPtr markerPtr, int index, char name, int nameLen, byte type, byte unit);
    static public void SingleSampleWithMetadata(IntPtr markerPtr, int metadataCount, void metadata);

    public struct TimestampConversionRatio
    {
        public long Denominator;
        public long Numerator;

    }

}

}
