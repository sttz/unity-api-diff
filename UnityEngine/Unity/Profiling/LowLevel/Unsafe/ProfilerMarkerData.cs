using System;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{

public struct ProfilerMarkerData
{
    public void ptr;
    public byte reserved0;
    public ushort reserved1;
    public uint size;
    public Unity.Profiling.LowLevel.ProfilerMarkerDataType type;

}

}
