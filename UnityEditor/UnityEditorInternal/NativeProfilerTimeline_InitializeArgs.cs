using System;
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
    public float textFadeOutWidth;
    public float textFadeStartWidth;

    public void Reset();

}

}
