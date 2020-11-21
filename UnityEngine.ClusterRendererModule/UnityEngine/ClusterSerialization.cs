using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class ClusterSerialization
{
    static public bool RestoreClusterInputState(Unity.Collections.NativeArray<byte> buffer);
    static public bool RestoreInputManagerState(Unity.Collections.NativeArray<byte> buffer);
    static public bool RestoreTimeManagerState(Unity.Collections.NativeArray<byte> buffer);
    static public int SaveClusterInputState(Unity.Collections.NativeArray<byte> buffer);
    static public int SaveInputManagerState(Unity.Collections.NativeArray<byte> buffer);
    static public int SaveTimeManagerState(Unity.Collections.NativeArray<byte> buffer);

}

}
