using System;
using UnityEngine;

namespace UnityEditor.Profiling
{

public class HierarchyFrameDataView : UnityEditor.Profiling.FrameDataView
{
    static public int columnCalls = 3;
    static public int columnDontSort = -1;
    static public int columnGcMemory = 4;
    static public int columnName = 0;
    static public int columnObjectName = 13;
    static public int columnSelfPercent = 2;
    static public int columnSelfTime = 6;
    static public int columnStartTime = 14;
    static public int columnTotalPercent = 1;
    static public int columnTotalTime = 5;
    static public int columnWarningCount = 12;
    static public int invalidSampleId = -1;

    public int sortColumn { get; }
    public bool sortColumnAscending { get; }
    public ViewModes viewMode { get; }

    public bool Equals(object obj);
    public int GetHashCode();
    public void GetItemAncestors(int id, System.Collections.Generic.List<int> outAncestors);
    public void GetItemCallstack(int id, System.Collections.Generic.List<ulong> outCallstack);
    public ushort GetItemCategoryIndex(int id);
    public void GetItemChildren(int id, System.Collections.Generic.List<int> outChildren);
    public string GetItemColumnData(int id, int column);
    public double GetItemColumnDataAsDouble(int id, int column);
    public float GetItemColumnDataAsFloat(int id, int column);
    public float GetItemColumnDataAsSingle(int id, int column);
    public int GetItemDepth(int id);
    public void GetItemDescendantsThatHaveChildren(int id, System.Collections.Generic.List<int> outChildren);
    public int GetItemInstanceID(int id);
    public Unity.Profiling.LowLevel.MarkerFlags GetItemMarkerFlags(int id);
    public int GetItemMarkerID(int id);
    public void GetItemMarkerIDPath(int id, System.Collections.Generic.List<int> outFullIdPath);
    public void GetItemMergedSampleCallstack(int id, int sampleIndex, System.Collections.Generic.List<ulong> outCallstack);
    public void GetItemMergedSamplesColumnData(int id, int column, System.Collections.Generic.List<string> outStrings);
    public void GetItemMergedSamplesColumnDataAsFloats(int id, int column, System.Collections.Generic.List<float> outValues);
    public int GetItemMergedSamplesCount(int id);
    public void GetItemMergedSamplesInstanceID(int id, System.Collections.Generic.List<int> outInstanceIds);
    public string GetItemMetadata(int id, int index);
    public float GetItemMetadataAsFloat(int id, int index);
    public long GetItemMetadataAsLong(int id, int index);
    public int GetItemMetadataCount(int id);
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
