using System;
using UnityEngine;

namespace UnityEngine
{

public interface ISubsystemDescriptor
{
    public string id { get; }

    public ISubsystem Create();

}

}
