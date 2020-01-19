using System;
using System.Collections;
using System.Collections.Generic;
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
