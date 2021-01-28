using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class ProfilerWindow : UnityEditor.EditorWindow, UnityEditor.IHasCustomMenu, UnityEditorInternal.IProfilerWindowController, IResponder
{
    static public string cpuModuleName = "CPU Usage";
    static public string gpuModuleName = "GPU Usage";

    public long firstAvailableFrameIndex { get; }
    public long lastAvailableFrameIndex { get; }
    public long selectedFrameIndex { get; set; }
    public string selectedModuleName { get; }

    public UnityEditor.Profiling.IProfilerFrameTimeViewSampleSelectionController GetFrameTimeViewSampleSelectionController(string moduleName);
    public void SelectAndStayOnLatestFrame();

}

}
