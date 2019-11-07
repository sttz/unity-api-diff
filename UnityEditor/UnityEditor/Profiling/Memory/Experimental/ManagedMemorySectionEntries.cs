using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class ManagedMemorySectionEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<byte[]> bytes { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> startAddress { get; }

    public uint GetNumEntries();

}

}
