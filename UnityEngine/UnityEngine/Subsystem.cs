using System;
using UnityEngine;

namespace UnityEngine
{

public abstract class Subsystem : ISubsystem
{
    public bool running { get; }

    protected Subsystem();

    public void Destroy();
    public void Start();
    public void Stop();

}

}
