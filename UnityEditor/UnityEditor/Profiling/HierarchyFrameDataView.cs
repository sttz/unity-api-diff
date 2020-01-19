using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public class HierarchyFrameDataView : IDisposable
{
    static public int columnCalls = 3;
    static public int columnDontSort = -1;
    static public int columnGcMemory = 4;
    static public int columnName = 0;
    static public int columnObjectName = 13;
    static public int columnSelfPercent = 2;
    static public int columnSelfTime = 6;
    static public int columnTotalPercent = 1;
    static public int columnTotalTime = 5;
    static public int columnWarningCount = 12;
    static public int invalidSampleId = -1;

    public float frameFps { get; }
    public float frameGpuTimeMs { get; }
    public int frameIndex { get; }
    public float frameTimeMs { get; }
    public int sortColumn { get; }
    public bool sortColumnAscending { get; }
    public string threadGroupName { get; }
    public ulong threadId { get; }
    public int threadIndex { get; }
    public string threadName { get; }
    public bool valid { get; }
    public ViewModes viewMode { get; }

    public void Dispose();
    public bool Equals(object obj);
    public Unity.Collections.NativeArray<T> GetFrameMetaData<T>(Guid id, int tag);
    public Unity.Collections.NativeArray<T> GetFrameMetaData<T>(Guid id, int tag, int index);
    public int GetFrameMetaDataCount(Guid id, int tag);
    public int GetHashCode();
    public void GetItemAncestors(int id, List<int> outAncestors);
    public void GetItemChildren(int id, List<int> outChildren);
    public string GetItemColumnData(int id, int column);
    public float GetItemColumnDataAsSingle(int id, int column);
    public int GetItemDepth(int id);
    public void GetItemDescendantsThatHaveChildren(int id, List<int> outChildren);
    public int GetItemInstanceID(int id);
    public int GetItemMarkerID(int id);
    public void GetItemMarkerIDPath(int id, List<int> outFullIdPath);
    public void GetItemMergedSamplesColumnData(int id, int column, List<string> outStrings);
    public void GetItemMergedSamplesColumnDataAsFloats(int id, int column, List<float> outValues);
    public int GetItemMergedSamplesCount(int id);
    public void GetItemMergedSamplesInstanceID(int id, List<int> outInstanceIds);
    public string GetItemName(int id);
    public string GetItemPath(int id);
    public int GetRootItemID();
    public bool HasItemChildren(int id);
    public string ResolveItemCallstack(int id);
    public string ResolveItemMergedSampleCallstack(int id, int sampleIndex);
    public void Sort(int sortColumn, bool sortAscending);

    public enum ViewModes
    {
        Default = 0,
        MergeSamplesWithTheSameName = 1,
        HideEditorOnlySamples = 2,
    }

}

}
