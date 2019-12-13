using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class NativeProfilerTimeline
{
    static public void Draw(UnityEditorInternal.NativeProfilerTimeline_DrawArgs args);
    static public bool GetEntryAtPosition(UnityEditorInternal.NativeProfilerTimeline_GetEntryAtPositionArgs args);
    static public bool GetEntryInstanceInfo(UnityEditorInternal.NativeProfilerTimeline_GetEntryInstanceInfoArgs args);
    static public bool GetEntryPositionInfo(UnityEditorInternal.NativeProfilerTimeline_GetEntryPositionInfoArgs args);
    static public bool GetEntryTimingInfo(UnityEditorInternal.NativeProfilerTimeline_GetEntryTimingInfoArgs args);
    static public void Initialize(UnityEditorInternal.NativeProfilerTimeline_InitializeArgs args);

    public NativeProfilerTimeline();

}

}
