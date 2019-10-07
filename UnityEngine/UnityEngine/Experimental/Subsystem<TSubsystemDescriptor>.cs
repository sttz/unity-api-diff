using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public abstract class Subsystem<TSubsystemDescriptor> : Experimental.Subsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    protected Subsystem();

}

}
