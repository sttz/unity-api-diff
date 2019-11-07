using System;
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
