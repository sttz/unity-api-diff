using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public static class MemorySnapshot
{
    static public event Action<UnityEditor.MemoryProfiler.PackedMemorySnapshot> OnSnapshotReceived;

    static public void RequestNewSnapshot();

}

}
