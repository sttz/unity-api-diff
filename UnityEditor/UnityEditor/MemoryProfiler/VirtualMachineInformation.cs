using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct VirtualMachineInformation
{
    public int allocationGranularity { get; }
    public int arrayBoundsOffsetInHeader { get; }
    public int arrayHeaderSize { get; }
    public int arraySizeOffsetInHeader { get; }
    public int heapFormatVersion { get; }
    public int objectHeaderSize { get; }
    public int pointerSize { get; }

}

}
