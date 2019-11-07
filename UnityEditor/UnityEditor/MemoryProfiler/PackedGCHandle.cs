using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct PackedGCHandle
{
    public ulong target { get; }

    public PackedGCHandle(ulong target);

}

}
