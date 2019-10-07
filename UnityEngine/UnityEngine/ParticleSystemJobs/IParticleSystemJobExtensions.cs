using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public static class IParticleSystemJobExtensions
{
    static public Unity.Jobs.JobHandle Schedule(T jobData, ParticleSystem ps, Unity.Jobs.JobHandle dependsOn = null);
    static public Unity.Jobs.JobHandle Schedule(T jobData, ParticleSystem ps, int minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn = null);
    static public Unity.Jobs.JobHandle ScheduleBatch(T jobData, ParticleSystem ps, int innerLoopBatchCount, Unity.Jobs.JobHandle dependsOn = null);

}

}
