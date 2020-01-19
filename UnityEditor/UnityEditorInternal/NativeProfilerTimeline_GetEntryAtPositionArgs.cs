using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_GetEntryAtPositionArgs
{
    public int frameIndex;
    public int out_EntryIndex;
    public string out_EntryName;
    public float out_EntryYMaxPos;
    public Vector2 position;
    public Rect shownAreaRect;
    public int threadIndex;
    public Rect threadRect;
    public float timeOffset;

    public void Reset();

}

}
