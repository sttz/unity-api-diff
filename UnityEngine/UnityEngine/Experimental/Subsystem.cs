using System;
using UnityEngine;

namespace UnityEngine.Experimental
{

public abstract class Subsystem : Experimental.ISubsystem
{
    protected Subsystem();

    public void Destroy();
    public void Start();
    public void Stop();

}

}
