using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Subsystems
{

public class ExampleSubsystem : IntegratedSubsystem<Subsystems.ExampleSubsystemDescriptor>
{
    public ExampleSubsystem();

    public bool GetBool();
    public void PrintExample();

}

}
