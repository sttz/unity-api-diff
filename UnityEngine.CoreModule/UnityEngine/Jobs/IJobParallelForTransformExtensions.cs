using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Jobs
{

public static class IJobParallelForTransformExtensions
{
    static public void RunReadOnly<T>(T jobData, Jobs.TransformAccessArray transforms);
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn = null);
    static public Unity.Jobs.JobHandle ScheduleReadOnly<T>(T jobData, Jobs.TransformAccessArray transforms, int batchSize, Unity.Jobs.JobHandle dependsOn = null);

}

}
