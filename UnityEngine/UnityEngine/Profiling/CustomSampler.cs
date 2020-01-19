using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Profiling
{

public sealed class CustomSampler : Profiling.Sampler
{
    static public Profiling.CustomSampler Create(string name);

    public void Begin();
    public void Begin(Object targetObject);
    public void End();

}

}
