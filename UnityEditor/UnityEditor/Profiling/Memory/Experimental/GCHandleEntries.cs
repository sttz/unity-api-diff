using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class GCHandleEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> target { get; }

    public uint GetNumEntries();

}

}
