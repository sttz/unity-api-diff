using System;
using UnityEngine;

namespace UnityEditorInternal
{

public struct NativeProfilerTimeline_GetEntryInstanceInfoArgs
{
    public int entryIndex;
    public int frameIndex;
    public string out_CallstackInfo;
    public int out_Id;
    public string out_MetaData;
    public string out_Path;
    public int threadIndex;

    public void Reset();

}

}
