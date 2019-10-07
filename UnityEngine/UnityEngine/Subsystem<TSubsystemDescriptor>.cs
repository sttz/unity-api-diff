using System;
using UnityEngine;

namespace UnityEngine
{

public abstract class Subsystem<TSubsystemDescriptor> : Subsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    protected Subsystem();

}

}
