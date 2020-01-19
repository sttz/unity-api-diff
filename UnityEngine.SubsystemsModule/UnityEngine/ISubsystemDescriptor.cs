using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public interface ISubsystemDescriptor
{
    public string id { get; }

    public ISubsystem Create();

}

}
