using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_GetEntryPositionInfoArgs
{
    public int frameIndex;
    public int out_Depth;
    public Vector2 out_Position;
    public Vector2 out_Size;
    public int sampleIndex;
    public Rect shownAreaRect;
    public int threadIndex;
    public Rect threadRect;
    public float timeOffset;

    public void Reset();

}

}
