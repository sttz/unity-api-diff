using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling
{

public struct ProfilerMarker
{
    public IntPtr Handle { get; }

    public ProfilerMarker(string name);

    public AutoScope Auto();
    public void Begin();
    public void Begin(Object contextUnityObject);
    public void End();

    public struct AutoScope : IDisposable
    {
        public void Dispose();

    }

}

}
