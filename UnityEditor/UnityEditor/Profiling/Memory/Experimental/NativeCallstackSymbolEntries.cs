using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class NativeCallstackSymbolEntries
{
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<string> readableStackTrace { get; }
    public UnityEditor.Profiling.Memory.Experimental.ArrayEntries<ulong> symbol { get; }

    public uint GetNumEntries();

}

}
