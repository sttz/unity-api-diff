using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Diagnostics
{

public enum ForcedCrashCategory
{
    AccessViolation = 0,
    FatalError = 1,
    Abort = 2,
    PureVirtualFunction = 3,
    MonoAbort = 4,
}

}
