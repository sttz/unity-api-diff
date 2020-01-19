using System;
using System.Collections;
using System.Collections.Generic;
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
