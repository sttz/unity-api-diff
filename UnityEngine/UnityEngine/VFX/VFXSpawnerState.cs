using System;
using UnityEngine;

namespace UnityEngine.VFX
{

public sealed class VFXSpawnerState : IDisposable
{
    public float delayAfterLoop { get; set; }
    public float delayBeforeLoop { get; set; }
    public float deltaTime { get; set; }
    public int loopCount { get; set; }
    public float loopDuration { get; set; }
    public int loopIndex { get; set; }
    public VFX.VFXSpawnerLoopState loopState { get; set; }
    public bool newLoop { get; }
    public bool playing { get; set; }
    public float spawnCount { get; set; }
    public float totalTime { get; set; }
    public VFX.VFXEventAttribute vfxEventAttribute { get; }

    public void Dispose();

}

}
