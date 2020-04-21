using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_GetEntryTimingInfoArgs
{
    public bool calculateFrameData;
    public int entryIndex;
    public int frameIndex;
    public float out_Duration;
    public int out_InstanceCountForFrame;
    public float out_LocalStartTime;
    public float out_TotalDurationForFrame;
    public int threadIndex;

    public void Reset();

}

}
