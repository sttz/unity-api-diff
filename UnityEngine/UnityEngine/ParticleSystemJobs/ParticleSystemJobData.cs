using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public struct ParticleSystemJobData
{
    public Unity.Collections.NativeArray<float> aliveTimePercent { get; }
    public int count { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray4 customData1 { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray4 customData2 { get; }
    public Unity.Collections.NativeArray<float> inverseStartLifetimes { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray3 positions { get; }
    public Unity.Collections.NativeArray<uint> randomSeeds { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray3 rotationalSpeeds { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray3 rotations { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray3 sizes { get; }
    public Unity.Collections.NativeArray<Color32> startColors { get; }
    public ParticleSystemJobs.ParticleSystemNativeArray3 velocities { get; }

}

}
