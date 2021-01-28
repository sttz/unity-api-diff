using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public static class ProfilerEditorUtility
{
    static public bool SetSelection(UnityEditor.Profiling.IProfilerFrameTimeViewSampleSelectionController controller, string markerNameOrMarkerNamePath, long frameIndex = -1, string threadGroupName = "", string threadName = "Main Thread", ulong threadId = 0);
    static public bool SetSelection(UnityEditor.Profiling.IProfilerFrameTimeViewSampleSelectionController controller, long frameIndex, string threadGroupName, string threadName, int sampleMarkerId, List<int> markerIdPath = null, ulong threadId = 0);
    static public bool SetSelection(UnityEditor.Profiling.IProfilerFrameTimeViewSampleSelectionController controller, long frameIndex, string threadGroupName, string threadName, string sampleName, string markerNamePath = null, ulong threadId = 0);

}

}
