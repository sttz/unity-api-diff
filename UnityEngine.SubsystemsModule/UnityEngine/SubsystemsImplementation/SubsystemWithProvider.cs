using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public abstract class SubsystemWithProvider : ISubsystem
{
    public bool running { get; private set; }

    protected SubsystemWithProvider();

    public void Destroy();
    protected void OnDestroy();
    protected void OnStart();
    protected void OnStop();
    public void Start();
    public void Stop();

}

}
