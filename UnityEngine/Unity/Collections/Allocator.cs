using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections
{

public enum Allocator
{
    Invalid = 0,
    None = 1,
    Temp = 2,
    TempJob = 3,
    Persistent = 4,
}

}
