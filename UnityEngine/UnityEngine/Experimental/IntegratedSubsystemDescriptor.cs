using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public abstract class IntegratedSubsystemDescriptor : Experimental.ISubsystemDescriptorImpl, Experimental.ISubsystemDescriptor
{
    public bool disablesLegacyVr { get; }
    public string id { get; }

    protected IntegratedSubsystemDescriptor();

}

}
