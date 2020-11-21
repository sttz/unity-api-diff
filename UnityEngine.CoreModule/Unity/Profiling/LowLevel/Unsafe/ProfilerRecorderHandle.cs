using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{

public struct ProfilerRecorderHandle
{
    static public void GetAvailable(List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle> outRecorderHandleList);
    static public Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);

    public bool Valid { get; }

}

}
