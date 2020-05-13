using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public interface ISubsystem : IRunning
{
    public void Destroy();
    public void Start();
    public void Stop();

}

}
