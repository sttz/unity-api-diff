using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public enum ProcessingState
{
    Unknown = 0,
    InQueue = 1,
    Reading = 2,
    Completed = 3,
    Failed = 4,
    Canceled = 5,
}

}
