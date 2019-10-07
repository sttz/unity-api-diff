using System;
using UnityEngine;

namespace UnityEngine
{

public interface ISubsystem
{
    public bool running { get; }

    public void Destroy();
    public void Start();
    public void Stop();

}

}
