using System;
using UnityEngine;

namespace UnityEngine
{

public abstract class SubsystemDescriptor : ISubsystemDescriptor
{
    public string id { get; set; }
    public Type subsystemImplementationType { get; set; }

    protected SubsystemDescriptor();

}

}
