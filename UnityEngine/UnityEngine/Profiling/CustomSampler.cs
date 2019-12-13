using System;
using UnityEngine;

namespace UnityEngine.Profiling
{

public sealed class CustomSampler : Profiling.Sampler
{
    static public Profiling.CustomSampler Create(string name, bool collectGpuData = false);

    public void Begin();
    public void Begin(Object targetObject);
    public void End();

}

}