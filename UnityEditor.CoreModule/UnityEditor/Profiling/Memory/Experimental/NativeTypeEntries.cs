using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeTypeEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<int> nativeBaseTypeArrayIndex { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> typeName { get; }

    public uint GetNumEntries();

}

}
