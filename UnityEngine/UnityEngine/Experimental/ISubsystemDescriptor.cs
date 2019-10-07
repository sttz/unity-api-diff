using System;
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
