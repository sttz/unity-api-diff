using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class Subsystem<TSubsystemDescriptor> : Subsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    protected Subsystem();

}

}
