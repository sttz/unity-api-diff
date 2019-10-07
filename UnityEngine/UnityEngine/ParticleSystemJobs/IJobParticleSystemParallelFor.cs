using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystemParallelFor
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData, int index);

}

}
