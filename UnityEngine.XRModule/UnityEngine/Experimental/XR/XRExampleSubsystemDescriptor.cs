using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<Experimental.XR.XRExampleSubsystem>
{
    public bool disableBackbufferMSAA { get; }
    public bool stereoscopicBackbuffer { get; }
    public bool supportsEditorMode { get; }
    public bool usePBufferEGL { get; }

    public XRExampleSubsystemDescriptor();

}

}
