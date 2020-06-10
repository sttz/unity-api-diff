using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public enum TypeFlags
{
    kArrayRankMask = -65536,
    kNone = 0,
    kValueType = 1,
    kArray = 2,
}

}
