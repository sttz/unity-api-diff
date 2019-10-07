using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public abstract class SubsystemDescriptor : Experimental.ISubsystemDescriptor
{
    public string id { get; set; }
    public Type subsystemImplementationType { get; set; }

    protected SubsystemDescriptor();

}

}
