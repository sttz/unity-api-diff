using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeRootReferenceEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> accumulatedSize { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> areaName { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<long> id { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> objectName { get; }

    public uint GetNumEntries();

}

}
