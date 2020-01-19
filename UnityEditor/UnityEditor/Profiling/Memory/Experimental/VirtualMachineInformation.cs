using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public struct VirtualMachineInformation
{
    public int allocationGranularity { get; internal set; }
    public int arrayBoundsOffsetInHeader { get; internal set; }
    public int arrayHeaderSize { get; internal set; }
    public int arraySizeOffsetInHeader { get; internal set; }
    public int objectHeaderSize { get; internal set; }
    public int pointerSize { get; internal set; }

}

}
