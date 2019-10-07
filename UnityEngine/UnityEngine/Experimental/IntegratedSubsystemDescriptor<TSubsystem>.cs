using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public class IntegratedSubsystemDescriptor<TSubsystem> : Experimental.IntegratedSubsystemDescriptor
{
    public IntegratedSubsystemDescriptor();

    public TSubsystem Create();

}

}
