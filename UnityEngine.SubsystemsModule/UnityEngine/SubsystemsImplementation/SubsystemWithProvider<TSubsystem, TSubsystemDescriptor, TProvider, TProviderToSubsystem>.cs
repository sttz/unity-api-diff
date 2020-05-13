using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public abstract class SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider, TProviderToSubsystem> : SubsystemsImplementation.SubsystemWithProvider
{
    public TSubsystemDescriptor subsystemDescriptor { get; private set; }

    protected SubsystemWithProvider();

    protected void OnDestroy();
    protected void OnStart();
    protected void OnStop();

}

}
