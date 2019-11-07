using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public enum TypeFlags
{
    kNone = 0,
    kValueType = 1,
    kArray = 2,
    kArrayRankMask = -65536,
}

}
