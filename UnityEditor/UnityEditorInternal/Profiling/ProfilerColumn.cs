using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.Profiling
{

public enum ProfilerColumn
{
    DontSort = -1,
    FunctionName = 0,
    TotalPercent = 1,
    SelfPercent = 2,
    Calls = 3,
    GCMemory = 4,
    TotalTime = 5,
    SelfTime = 6,
    DrawCalls = 7,
    TotalGPUTime = 8,
    SelfGPUTime = 9,
    TotalGPUPercent = 10,
    SelfGPUPercent = 11,
    WarningCount = 12,
    ObjectName = 13,
}

}
