using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct PackedNativeType
{
    public int baseClassId { get; }
    public string name { get; }
    public int nativeBaseTypeArrayIndex { get; }

    public PackedNativeType(string name, int nativeBaseTypeArrayIndex);

}

}
