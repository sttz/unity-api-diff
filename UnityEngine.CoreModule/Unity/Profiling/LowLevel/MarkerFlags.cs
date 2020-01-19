using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling.LowLevel
{

public enum MarkerFlags : ushort
{
    Default = 0,
    Script = 2,
    AvailabilityEditor = 4,
    Warning = 16,
    ScriptInvoke = 32,
    ScriptDeepProfiler = 64,
    Counter = 128,
}

}
