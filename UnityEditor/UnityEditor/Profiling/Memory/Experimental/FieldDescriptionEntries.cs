using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class FieldDescriptionEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> fieldDescriptionName { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<bool> isStatic { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> offset { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> typeIndex { get; }

    public uint GetNumEntries();

}

}
