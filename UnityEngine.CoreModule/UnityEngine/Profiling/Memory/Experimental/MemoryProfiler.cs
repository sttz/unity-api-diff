using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling.Memory.Experimental
{

public sealed class MemoryProfiler
{
    static public event Action<Profiling.Memory.Experimental.MetaData> createMetaData;

    static public void TakeSnapshot(string path, Action<string, bool> finishCallback, Profiling.Memory.Experimental.CaptureFlags captureFlags = 3);
    static public void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, Profiling.Experimental.DebugScreenCapture> screenshotCallback, Profiling.Memory.Experimental.CaptureFlags captureFlags = 3);
    static public void TakeTempSnapshot(Action<string, bool> finishCallback, Profiling.Memory.Experimental.CaptureFlags captureFlags = 3);

    public MemoryProfiler();

}

}
