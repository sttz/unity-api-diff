using System;
using UnityEngine;

namespace UnityEngine
{

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem
{
    public TSubsystemDescriptor SubsystemDescriptor { get; }

    public IntegratedSubsystem();

}

}
