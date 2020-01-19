using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystemParallelForBatch
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData, int startIndex, int count);

}

}
