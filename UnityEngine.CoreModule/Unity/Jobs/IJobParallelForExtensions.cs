using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Jobs
{

public static class IJobParallelForExtensions
{
    static public void Run<T>(T jobData, int arrayLength);
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn = null);

}

}
