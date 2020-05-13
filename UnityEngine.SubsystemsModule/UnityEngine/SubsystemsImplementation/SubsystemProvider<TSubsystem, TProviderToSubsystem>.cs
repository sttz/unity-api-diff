using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public abstract class SubsystemProvider<TSubsystem, TProviderToSubsystem> : SubsystemsImplementation.SubsystemProvider, IRunning
{
    public bool running { get; }

    protected SubsystemProvider();

    public void Destroy();
    public void Start();
    public void Stop();

}

}
