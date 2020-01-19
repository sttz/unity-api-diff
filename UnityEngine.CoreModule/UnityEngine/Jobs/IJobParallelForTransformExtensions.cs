using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Jobs
{

public static class IJobParallelForTransformExtensions
{
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn = null);

}

}
