using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public static class MemorySnapshot
{
    static public event Action<UnityEditor.MemoryProfiler.PackedMemorySnapshot> OnSnapshotReceived;

    static public void RequestNewSnapshot();

}

}
