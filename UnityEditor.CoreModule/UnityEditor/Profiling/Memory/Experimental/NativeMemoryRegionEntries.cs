using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeMemoryRegionEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> addressBase { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> addressSize { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> firstAllocationIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> memoryRegionName { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> numAllocations { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> parentIndex { get; }

    public uint GetNumEntries();

}

}
