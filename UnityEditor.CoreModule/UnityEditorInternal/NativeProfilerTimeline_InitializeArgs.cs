using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_InitializeArgs
{
    public float ghostAlpha;
    public IntPtr guiStyle;
    public float lineHeight;
    public float nonSelectedAlpha;
    public UnityEditorInternal.ProfilerColorDescriptor[] profilerColorDescriptors;
    public int showFullScriptingMethodNames;
    public float textFadeOutWidth;
    public float textFadeStartWidth;

    public void Reset();

}

}
