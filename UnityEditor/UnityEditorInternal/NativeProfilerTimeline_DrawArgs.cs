using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_DrawArgs
{
    public int frameIndex;
    public int mousedOverEntryIndex;
    public int selectedEntryIndex;
    public Rect shownAreaRect;
    public int threadIndex;
    public Rect threadRect;
    public float timeOffset;

    public void Reset();

}

}
