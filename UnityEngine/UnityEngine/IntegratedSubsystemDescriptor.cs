using System;
using UnityEngine;

namespace UnityEngine
{

public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptorImpl, ISubsystemDescriptor
{
    public string id { get; }

    protected IntegratedSubsystemDescriptor();

}

}
