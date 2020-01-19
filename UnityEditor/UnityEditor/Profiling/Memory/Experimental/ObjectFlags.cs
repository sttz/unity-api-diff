using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public enum ObjectFlags
{
    IsDontDestroyOnLoad = 1,
    IsPersistent = 2,
    IsManager = 4,
}

}
