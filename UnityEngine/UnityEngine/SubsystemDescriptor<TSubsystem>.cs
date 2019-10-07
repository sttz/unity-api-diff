using System;
using UnityEngine;

namespace UnityEngine
{

public class SubsystemDescriptor<TSubsystem> : SubsystemDescriptor
{
    public SubsystemDescriptor();

    public TSubsystem Create();

}

}
