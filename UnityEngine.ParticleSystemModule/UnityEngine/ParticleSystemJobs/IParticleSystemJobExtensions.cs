using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public static class IParticleSystemJobExtensions
{
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, ParticleSystem ps, Unity.Jobs.JobHandle dependsOn = null);
    static public Unity.Jobs.JobHandle Schedule<T>(T jobData, ParticleSystem ps, int minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn = null);
    static public Unity.Jobs.JobHandle ScheduleBatch<T>(T jobData, ParticleSystem ps, int innerLoopBatchCount, Unity.Jobs.JobHandle dependsOn = null);

}

}
