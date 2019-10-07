using System;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public struct ParticleSystemNativeArray4
{
    public Unity.Collections.NativeArray<float> w;
    public Unity.Collections.NativeArray<float> x;
    public Unity.Collections.NativeArray<float> y;
    public Unity.Collections.NativeArray<float> z;

    public Vector4 this[int index] { get; set; }

}

}
