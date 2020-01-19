using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    public IntegratedSubsystem();

}

}
