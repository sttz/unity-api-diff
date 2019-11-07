using System;
using UnityEngine;

namespace UnityEngine.Subsystems
{

public class ExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<Subsystems.ExampleSubsystem>
{
    public bool disableBackbufferMSAA { get; }
    public bool stereoscopicBackbuffer { get; }
    public bool supportsEditorMode { get; }
    public bool usePBufferEGL { get; }

    public ExampleSubsystemDescriptor();

}

}
