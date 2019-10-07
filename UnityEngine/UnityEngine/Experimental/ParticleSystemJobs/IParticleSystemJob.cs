using System;
using UnityEngine;

namespace UnityEngine.Experimental.ParticleSystemJobs
{

public interface IParticleSystemJob
{
    public void ProcessParticleSystem(Experimental.ParticleSystemJobs.ParticleSystemJobData jobData);

}

}
