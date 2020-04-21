using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public static class TypeFlagsExtensions
{
    static public int ArrayRank(UnityEditor.Profiling.Memory.Experimental.TypeFlags flags);
    static public bool IsArray(UnityEditor.Profiling.Memory.Experimental.TypeFlags flags);
    static public bool IsValueType(UnityEditor.Profiling.Memory.Experimental.TypeFlags flags);

}

}
