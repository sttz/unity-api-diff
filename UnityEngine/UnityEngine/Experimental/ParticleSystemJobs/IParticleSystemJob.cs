using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.ParticleSystemJobs
{

public interface IParticleSystemJob
{
    public void ProcessParticleSystem(Experimental.ParticleSystemJobs.ParticleSystemJobData jobData);

}

}
