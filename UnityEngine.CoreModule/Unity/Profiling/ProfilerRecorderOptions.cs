using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling
{

public enum ProfilerRecorderOptions
{
    None = 0,
    StartImmediately = 1,
    KeepAliveDuringDomainReload = 2,
    CollectOnlyOnCurrentThread = 4,
    WrapAroundWhenCapacityReached = 8,
    SumAllSamplesInFrame = 16,
    Default = 24,
}

}
