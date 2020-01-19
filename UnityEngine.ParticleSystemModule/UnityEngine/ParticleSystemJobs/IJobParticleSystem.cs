using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public interface IJobParticleSystem
{
    public void Execute(ParticleSystemJobs.ParticleSystemJobData jobData);

}

}
