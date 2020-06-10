using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public enum ProfilerMemoryRecordMode
{
    None = 0,
    GCAlloc = 1,
    UnsafeUtilityMalloc = 2,
    JobHandleComplete = 4,
    NativeAlloc = 8,
}

}
