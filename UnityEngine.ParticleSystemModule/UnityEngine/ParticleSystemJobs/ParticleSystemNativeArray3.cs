using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.ParticleSystemJobs
{

public struct ParticleSystemNativeArray3
{
    public Unity.Collections.NativeArray<float> x;
    public Unity.Collections.NativeArray<float> y;
    public Unity.Collections.NativeArray<float> z;

    public Vector3 this[int index] { get; set; }

}

}
