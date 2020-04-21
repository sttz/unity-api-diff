using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class IntegratedSubsystem : ISubsystem
{
    public bool running { get; }

    public IntegratedSubsystem();

    public void Destroy();
    public void Start();
    public void Stop();

}

}
