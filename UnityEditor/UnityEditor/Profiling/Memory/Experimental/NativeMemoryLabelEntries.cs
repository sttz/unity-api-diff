using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeMemoryLabelEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> memoryLabelName { get; }

    public uint GetNumEntries();

}

}
