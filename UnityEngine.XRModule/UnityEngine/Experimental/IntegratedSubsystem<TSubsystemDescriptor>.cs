using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public class IntegratedSubsystem<TSubsystemDescriptor> : Experimental.IntegratedSubsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    public IntegratedSubsystem();

}

}
