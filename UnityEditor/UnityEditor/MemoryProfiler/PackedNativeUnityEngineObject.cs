using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct PackedNativeUnityEngineObject
{
    public int classId { get; }
    public HideFlags hideFlags { get; }
    public int instanceId { get; }
    public bool isDontDestroyOnLoad { get; }
    public bool isManager { get; }
    public bool isPersistent { get; }
    public string name { get; }
    public long nativeObjectAddress { get; }
    public int nativeTypeArrayIndex { get; }
    public int size { get; }

    public PackedNativeUnityEngineObject(string name, int instanceId, int size, int nativeTypeArrayIndex, HideFlags hideFlags, ObjectFlags flags, long nativeObjectAddress);

    public enum ObjectFlags
    {
        IsDontDestroyOnLoad = 1,
        IsPersistent = 2,
        IsManager = 4,
    }

}

}
