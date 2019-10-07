using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystemParallelForBatch
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData, int startIndex, int count);

}

}
