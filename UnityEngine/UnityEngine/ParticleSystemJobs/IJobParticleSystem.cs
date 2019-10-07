using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystem
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData);

}

}
