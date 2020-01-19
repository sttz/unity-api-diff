using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeAllocationSiteEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong[]> callstackSymbols { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<long> id { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> memoryLabelIndex { get; }

    public uint GetNumEntries();

}

}
