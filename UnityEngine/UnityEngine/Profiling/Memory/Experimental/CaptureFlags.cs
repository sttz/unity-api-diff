using System;
using UnityEngine;

namespace UnityEngine.Profiling.Memory.Experimental
{

public enum CaptureFlags : uint
{
    ManagedObjects = 1,
    NativeObjects = 2,
    NativeAllocations = 4,
    NativeAllocationSites = 8,
    NativeStackTraces = 16,
}

}
