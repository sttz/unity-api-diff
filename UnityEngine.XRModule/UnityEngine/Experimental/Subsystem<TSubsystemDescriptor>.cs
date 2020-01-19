using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public abstract class Subsystem<TSubsystemDescriptor> : Experimental.Subsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    protected Subsystem();

}

}
