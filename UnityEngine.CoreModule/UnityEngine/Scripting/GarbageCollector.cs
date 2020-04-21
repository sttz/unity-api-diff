using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Scripting
{

public static class GarbageCollector
{
    static public Mode GCMode { get; set; }
    static public ulong incrementalTimeSliceNanoseconds { get; set; }
    static public bool isIncremental { get; }

    static public event Action<Mode> GCModeChanged;

    static public bool CollectIncremental(ulong nanoseconds);

    public enum Mode
    {
        Disabled = 0,
        Enabled = 1,
    }

}

}
