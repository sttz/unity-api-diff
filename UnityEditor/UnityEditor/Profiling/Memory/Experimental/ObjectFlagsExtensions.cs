using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public static class ObjectFlagsExtensions
{
    static public bool IsDontDestroyOnLoad(UnityEditor.Profiling.Memory.Experimental.ObjectFlags flags);
    static public bool IsManager(UnityEditor.Profiling.Memory.Experimental.ObjectFlags flags);
    static public bool IsPersistent(UnityEditor.Profiling.Memory.Experimental.ObjectFlags flags);

}

}
