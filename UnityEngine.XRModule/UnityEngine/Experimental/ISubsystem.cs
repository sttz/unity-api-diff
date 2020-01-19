using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental
{

public interface ISubsystem
{
    public void Destroy();
    public void Start();
    public void Stop();

}

}
