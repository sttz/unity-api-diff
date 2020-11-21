using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public enum ReadStatus
{
    Complete = 0,
    InProgress = 1,
    Failed = 2,
    Truncated = 4,
}

}
