using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public class RawFrameDataView : UnityEditor.Profiling.FrameDataView
{
    public bool Equals(object obj);
    public void GetFlowEvents(List<FlowEvent> outFlowEvents);
    public int GetHashCode();
    public void GetSampleCallstack(int sampleIndex, List<ulong> outCallstack);
    public ushort GetSampleCategoryIndex(int sampleIndex);
    public int GetSampleChildrenCount(int sampleIndex);
    public int GetSampleChildrenCountRecursive(int sampleIndex);
    public Unity.Profiling.LowLevel.MarkerFlags GetSampleFlags(int sampleIndex);
    public void GetSampleFlowEvents(int sampleIndex, List<FlowEvent> outFlowEvents);
    public int GetSampleMarkerId(int sampleIndex);
    public double GetSampleMetadataAsDouble(int sampleIndex, int metadataIndex);
    public float GetSampleMetadataAsFloat(int sampleIndex, int metadataIndex);
    public int GetSampleMetadataAsInt(int sampleIndex, int metadataIndex);
    public long GetSampleMetadataAsLong(int sampleIndex, int metadataIndex);
    public string GetSampleMetadataAsString(int sampleIndex, int metadataIndex);
    public int GetSampleMetadataCount(int sampleIndex);
    public string GetSampleName(int sampleIndex);
    public double GetSampleStartTimeMs(int sampleIndex);
    public ulong GetSampleStartTimeNs(int sampleIndex);
    public float GetSampleTimeMs(int sampleIndex);
    public ulong GetSampleTimeNs(int sampleIndex);

    public struct FlowEvent
    {
        public Unity.Profiling.ProfilerFlowEventType FlowEventType;
        public uint FlowId;
        public int ParentSampleIndex;

    }

}

}
