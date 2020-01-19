using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor
{
    public IntegratedSubsystemDescriptor();

    public TSubsystem Create();

}

}
