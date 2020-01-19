using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct PackedGCHandle
{
    public ulong target { get; }

    public PackedGCHandle(ulong target);

}

}
