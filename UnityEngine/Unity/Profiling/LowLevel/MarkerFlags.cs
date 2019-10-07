using System;
using UnityEngine;

namespace Unity.Profiling.LowLevel
{

public enum MarkerFlags
{
    Default = 0,
    Script = 2,
    ScriptInvoke = 32,
    ScriptDeepProfiler = 64,
    AvailabilityEditor = 4,
    Warning = 16,
}

}
