using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public class SubsystemDescriptor<TSubsystem> : Experimental.SubsystemDescriptor
{
    public SubsystemDescriptor();

    public TSubsystem Create();

}

}
