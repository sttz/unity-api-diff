using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class TypeDescriptionEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> assembly { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> baseOrElementTypeIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int[]> fieldIndices { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<UnityEditor.Profiling.Memory.Experimental.TypeFlags> flags { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> size { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<byte[]> staticFieldBytes { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> typeDescriptionName { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> typeIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> typeInfoAddress { get; }

    public uint GetNumEntries();

}

}
