using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystemParallelFor
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData, int index);

}

}
