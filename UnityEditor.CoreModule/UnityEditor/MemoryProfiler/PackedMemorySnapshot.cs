using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public class PackedMemorySnapshot
{
    public UnityEditor.MemoryProfiler.Connection[] connections { get; }
    public UnityEditor.MemoryProfiler.PackedGCHandle[] gcHandles { get; }
    public UnityEditor.MemoryProfiler.MemorySection[] managedHeapSections { get; }
    public UnityEditor.MemoryProfiler.PackedNativeUnityEngineObject[] nativeObjects { get; }
    public UnityEditor.MemoryProfiler.PackedNativeType[] nativeTypes { get; }
    public UnityEditor.MemoryProfiler.TypeDescription[] typeDescriptions { get; }
    public UnityEditor.MemoryProfiler.VirtualMachineInformation virtualMachineInformation { get; }

    public PackedMemorySnapshot(UnityEditor.Profiling.Memory.Experimental.PackedMemorySnapshot snapshot);

}

}
