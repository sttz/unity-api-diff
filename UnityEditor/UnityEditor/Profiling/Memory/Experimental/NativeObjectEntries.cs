using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeObjectEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<UnityEditor.Profiling.Memory.Experimental.ObjectFlags> flags { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<HideFlags> hideFlags { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> instanceId { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> nativeObjectAddress { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> nativeTypeArrayIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> objectName { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<long> rootReferenceId { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> size { get; }

    public uint GetNumEntries();

}

}
