using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRExampleSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRExampleSubsystemDescriptor>
{
    public XRExampleSubsystem();

    public bool GetBool();
    public void PrintExample();

}

}
