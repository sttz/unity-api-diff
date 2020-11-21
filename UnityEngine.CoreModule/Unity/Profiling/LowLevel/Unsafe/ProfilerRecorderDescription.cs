using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{

public struct ProfilerRecorderDescription
{
    public Unity.Profiling.ProfilerCategory Category { get; }
    public Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType { get; }
    public Unity.Profiling.LowLevel.MarkerFlags Flags { get; }
    public string Name { get; }
    public byte NameUtf8 { get; }
    public int NameUtf8Len { get; }
    public Unity.Profiling.ProfilerMarkerDataUnit UnitType { get; }

}

}
