using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling
{

public interface IProfilerFrameTimeViewSampleSelectionController
{
    public int focusedThreadIndex { get; set; }
    public string sampleNameSearchFilter { get; set; }
    public UnityEditor.Profiling.ProfilerTimeSampleSelection selection { get; }

    public event Action<UnityEditor.Profiling.IProfilerFrameTimeViewSampleSelectionController, UnityEditor.Profiling.ProfilerTimeSampleSelection> selectionChanged;

    public void ClearSelection();
    public bool SetSelection(UnityEditor.Profiling.ProfilerTimeSampleSelection selection);

}

}
