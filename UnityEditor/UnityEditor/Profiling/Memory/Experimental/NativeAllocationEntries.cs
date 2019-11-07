using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeAllocationEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> address { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<long> allocationSiteId { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> memoryRegionIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> overheadSize { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> paddingSize { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<long> rootReferenceId { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> size { get; }

    public uint GetNumEntries();

}

}
