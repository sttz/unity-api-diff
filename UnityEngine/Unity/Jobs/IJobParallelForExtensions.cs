using System;
using UnityEngine;

namespace Unity.Jobs
{

public static class IJobParallelForExtensions
{
    static public void Run(T jobData, int arrayLength);
    static public Unity.Jobs.JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn = null);

}

}
