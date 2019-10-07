using System;
using UnityEngine;

namespace Unity.Profiling
{

public struct ProfilerMarker
{
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
