using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRExampleSubsystem : IntegratedSubsystem<Experimental.XR.XRExampleSubsystemDescriptor>
{
    public XRExampleSubsystem();

    public bool GetBool();
    public void PrintExample();

}

}
