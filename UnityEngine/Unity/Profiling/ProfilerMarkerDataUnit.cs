using System;
using UnityEngine;

namespace Unity.Profiling
{

public enum ProfilerMarkerDataUnit : byte
{
    Undefined = 0,
    TimeNanoseconds = 1,
    Bytes = 2,
    Count = 3,
    Percent = 4,
    FrequencyHz = 5,
}

}
