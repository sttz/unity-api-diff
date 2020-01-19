using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptorImpl, ISubsystemDescriptor
{
    public string id { get; }

    protected IntegratedSubsystemDescriptor();

}

}
