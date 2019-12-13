using System;
using UnityEngine;

namespace Unity.Profiling
{

public enum ProfilerCounterOptions : ushort
{
    None = 0,
    FlushOnEndOfFrame = 2,
    ResetToZeroOnFlush = 4,
}

}