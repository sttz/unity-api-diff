using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public enum AtomicSafetyErrorType
{
    Deallocated = 0,
    DeallocatedFromJob = 1,
    NotAllocatedFromJob = 2,
}

}
