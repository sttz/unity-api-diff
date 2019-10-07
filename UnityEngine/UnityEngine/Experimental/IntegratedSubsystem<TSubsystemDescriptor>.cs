using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public class IntegratedSubsystem<TSubsystemDescriptor> : Experimental.IntegratedSubsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    public IntegratedSubsystem();

}

}
