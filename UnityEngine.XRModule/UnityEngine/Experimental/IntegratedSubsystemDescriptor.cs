using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public class IntegratedSubsystemDescriptor : Experimental.ISubsystemDescriptor, Experimental.ISubsystemDescriptorImpl
{
    public string id { get; }

    public IntegratedSubsystemDescriptor();

}

}
