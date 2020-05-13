using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public class SubsystemDescriptorWithProvider<TSubsystem, TProviderToSubsystem> : SubsystemsImplementation.SubsystemDescriptorWithProvider
{
    public SubsystemDescriptorWithProvider();

    public TSubsystem Create();
    public TSubsystemProxy CreateProxy<TSubsystemProxy>();

}

}
