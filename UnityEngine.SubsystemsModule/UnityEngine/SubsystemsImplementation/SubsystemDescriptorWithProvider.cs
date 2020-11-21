using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.SubsystemsImplementation
{

public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor
{
    public string id { get; set; }

    protected SubsystemDescriptorWithProvider();

}

}
