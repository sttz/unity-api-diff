using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class ProfilerProperty : IDisposable
{
    static public void ReleaseUISystemProfilerRender(Texture2D t);
    static public Texture2D UISystemProfilerRender(int frameIndex, int renderDataIndex, int renderDataCount, bool renderOverdraw);

    public int depth { get; }
    public bool frameDataReady { get; }
    public string frameFPS { get; }
    public string frameGpuTime { get; }
    public string frameTime { get; }
    public bool HasChildren { get; }
    public int[] instanceIDs { get; }
    public bool onlyShowGPUSamples { get; set; }
    public string propertyName { get; }
    public string propertyPath { get; }

    public ProfilerProperty();

    public void Cleanup();
    public void Dispose();
    public UnityEditorInternal.AudioProfilerClipInfo[] GetAudioProfilerClipInfo();
    public UnityEditorInternal.AudioProfilerDSPInfo[] GetAudioProfilerDSPInfo();
    public UnityEditorInternal.AudioProfilerGroupInfo[] GetAudioProfilerGroupInfo();
    public string GetAudioProfilerNameByOffset(int offset);
    public string GetColumn(int column);
    public float GetColumnAsSingle(int colum);
    public string GetTooltip(int column);
    public int[] GetUISystemBatchInstanceIDs();
    public string GetUISystemEventMarkerNameByOffset(int offset);
    public UnityEditorInternal.EventMarker[] GetUISystemEventMarkers();
    public UnityEditorInternal.UISystemProfilerInfo[] GetUISystemProfilerInfo();
    public string GetUISystemProfilerNameByOffset(int offset);
    public void InitializeDetailProperty(UnityEditorInternal.ProfilerProperty source);
    public bool Next(bool enterChildren);
    public void ResetToRoot();
    public void SetRoot(int frame, int profilerSortColumn, int viewType);

}

}
