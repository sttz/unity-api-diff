using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs.LowLevel.Unsafe
{

public struct JobRanges
{
    public int BatchSize;
    public int IndicesPerPhase;
    public int NumJobs;
    public int NumPhases;
    public IntPtr PhaseData;
    public IntPtr StartEndIndex;
    public int TotalIterationCount;

}

}
