using System;
using UnityEngine;

namespace UnityEngine.Scripting
{

public static class GarbageCollector
{
    static public Mode GCMode { get; set; }

    static public event Action<Mode> GCModeChanged;

    public enum Mode
    {
        Disabled = 0,
        Enabled = 1,
    }

}

}
