using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public static class ProfilerDriver
{
    static public string directConnectionPort;

    static public int connectedProfiler { get; set; }
    static public bool deepProfiling { get; set; }
    static public string directConnectionUrl { get; }
    static public bool enabled { get; set; }
    static public int firstFrameIndex { get; }
    static public bool isGPUProfilerBuggyOnDriver { get; }
    static public bool isGPUProfilerSupported { get; }
    static public bool isGPUProfilerSupportedByOS { get; }
    static public int lastFrameIndex { get; }
    static public UnityEditorInternal.ProfilerMemoryRecordMode memoryRecordMode { get; set; }
    static public string miniMemoryOverview { get; }
    static public uint objectCount { get; }
    static public bool profileEditor { get; set; }
    static public bool profileGPU { get; set; }
    static public string selectedPropertyPath { get; set; }
    static public uint usedHeapSize { get; }

    static public event Action<int, int> NewProfilerFrameRecorded;

    static public void BeginInstrumentFunction(string fullName);
    static public void ClearAllFrames();
    static public void DirectIPConnect(string IP);
    static public void DirectURLConnect(string IP);
    static public void EndInstrumentFunction(string fullName);
    static public string[] GetAllStatisticsProperties();
    static public int[] GetAvailableProfilers();
    static public string GetConnectionIdentifier(int guid);
    static public string GetFormattedStatisticsValue(int frame, int identifier);
    static public UnityEditorInternal.GpuProfilingStatisticsAvailabilityStates GetGpuStatisticsAvailabilityState(int frame);
    static public void GetGpuStatisticsAvailabilityStates(int firstFrame, out UnityEditorInternal.GpuProfilingStatisticsAvailabilityStates[] buffer);
    static public string[] GetGraphStatisticsPropertiesForArea(Profiling.ProfilerArea area);
    static public UnityEditor.Profiling.HierarchyFrameDataView GetHierarchyFrameDataView(int frameIndex, int threadIndex, ViewModes viewMode, int sortColumn, bool sortAscending);
    static public int GetNextFrameIndex(int frame);
    static public string GetOverviewText(Profiling.ProfilerArea profilerArea, int frame);
    static public int GetPreviousFrameIndex(int frame);
    static public UnityEditor.Profiling.RawFrameDataView GetRawFrameDataView(int frameIndex, int threadIndex);
    static public void GetStatisticsAvailable(Profiling.ProfilerArea profilerArea, int firstFrame, out bool[] buffer);
    static public void GetStatisticsAvailable(Profiling.ProfilerArea profilerArea, int firstFrame, out int[] buffer);
    static public int GetStatisticsIdentifier(string propertyName);
    static public int GetStatisticsIdentifierForArea(Profiling.ProfilerArea profilerArea, string propertyName);
    static public void GetStatisticsValues(int identifier, int firstFrame, float scale, out float[] buffer, out float maxValue);
    static public void GetUISystemEventMarkersBatch(int firstFrame, int frameCount, out UnityEditorInternal.EventMarker[] buffer, out string[] names);
    static public int GetUISystemEventMarkersCount(int firstFrame, int frameCount);
    static public bool IsAreaEnabled(Profiling.ProfilerArea area);
    static public bool IsIdentifierConnectable(int guid);
    static public bool LoadProfile(string filename, bool keepExistingData);
    static public void QueryFunctionCallees(string fullname);
    static public void QueryInstrumentableFunctions();
    static public void RequestMemorySnapshot();
    static public void RequestObjectMemoryInfo(bool gatherObjectReferences);
    static public void ResetHistory();
    static public void SaveProfile(string filename);
    static public void SetAreaEnabled(Profiling.ProfilerArea area, bool enabled);
    static public void SetAudioCaptureFlags(int flags);
    static public void SetAutoInstrumentedAssemblies(UnityEditorInternal.InstrumentedAssemblyTypes fullname);
    static public void SetMarkerFiltering(string name);

}

}
