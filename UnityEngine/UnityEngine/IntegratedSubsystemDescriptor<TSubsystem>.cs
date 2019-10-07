using System;
using UnityEngine;

namespace UnityEngine
{

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor
{
    public IntegratedSubsystemDescriptor();

    public TSubsystem Create();

}

}
