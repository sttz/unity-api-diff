using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public interface ISubsystemDescriptor
{
    public bool disablesLegacyVr { get; }
    public string id { get; }

    public Experimental.ISubsystem Create();

}

}
