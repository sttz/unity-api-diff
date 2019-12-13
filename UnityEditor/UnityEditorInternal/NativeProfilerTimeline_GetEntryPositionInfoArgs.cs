using System;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_GetEntryPositionInfoArgs
{
    public int entryIndex;
    public int frameIndex;
    public int out_Depth;
    public Vector2 out_Position;
    public Vector2 out_Size;
    public Rect shownAreaRect;
    public int threadIndex;
    public Rect threadRect;
    public float timeOffset;

    public void Reset();

}

}
