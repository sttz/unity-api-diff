using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class PackedMemorySnapshot : IDisposable
{
    static public bool Convert(UnityEditor.MemoryProfiler.PackedMemorySnapshot snapshot, string writePath);
    static public UnityEditor.Profiling.Memory.Experimental.PackedMemorySnapshot Load(string path);
    static public void Save(UnityEditor.Profiling.Memory.Experimental.PackedMemorySnapshot snapshot, string writePath);

    public Profiling.Memory.Experimental.CaptureFlags captureFlags { get; }
    public UnityEditor.Profiling.Memory.Experimental.ConnectionEntries connections { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.FieldDescriptionEntries fieldDescriptions { get; internal set; }
    public string filePath { get; }
    public UnityEditor.Profiling.Memory.Experimental.GCHandleEntries gcHandles { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.ManagedMemorySectionEntries managedHeapSections { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.ManagedMemorySectionEntries managedStacks { get; internal set; }
    public Profiling.Memory.Experimental.MetaData metadata { get; }
    public UnityEditor.Profiling.Memory.Experimental.NativeAllocationEntries nativeAllocations { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeAllocationSiteEntries nativeAllocationSites { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeCallstackSymbolEntries nativeCallstackSymbols { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeMemoryLabelEntries nativeMemoryLabels { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeMemoryRegionEntries nativeMemoryRegions { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeObjectEntries nativeObjects { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeRootReferenceEntries nativeRootReferences { get; internal set; }
    public UnityEditor.Profiling.Memory.Experimental.NativeTypeEntries nativeTypes { get; internal set; }
    public DateTime recordDate { get; }
    public UnityEditor.Profiling.Memory.Experimental.TypeDescriptionEntries typeDescriptions { get; internal set; }
    public uint version { get; }
    public UnityEditor.Profiling.Memory.Experimental.VirtualMachineInformation virtualMachineInformation { get; }

    public void Dispose();
    protected void Dispose(bool disposing);

}

}
