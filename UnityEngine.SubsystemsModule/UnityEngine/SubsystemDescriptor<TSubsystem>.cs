using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class SubsystemDescriptor<TSubsystem> : SubsystemDescriptor
{
    public SubsystemDescriptor();

    public TSubsystem Create();

}

}
