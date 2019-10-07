using System;
using UnityEngine;

namespace UnityEngine.Jobs
{

public static class IJobParallelForTransformExtensions
{
    static public Unity.Jobs.JobHandle Schedule(T jobData, Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn = null);

}

}
