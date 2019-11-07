using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class ConnectionEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> from { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> to { get; }

    public uint GetNumEntries();

}

}