using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.ParticleSystemJobs
{

public struct ParticleSystemJobData
{
    public Unity.Collections.NativeArray<float> aliveTimePercent { get; }
    public int count { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray4 customData1 { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray4 customData2 { get; }
    public Unity.Collections.NativeArray<float> inverseStartLifetimes { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray3 positions { get; }
    public Unity.Collections.NativeArray<uint> randomSeeds { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray3 rotationalSpeeds { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray3 rotations { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray3 sizes { get; }
    public Unity.Collections.NativeArray<Color32> startColors { get; }
    public Experimental.ParticleSystemJobs.ParticleSystemNativeArray3 velocities { get; }

}

}
