using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.VFX
{

public sealed class VFXSpawnerState : IDisposable
{
    public float deltaTime { get; set; }
    public bool playing { get; set; }
    public float spawnCount { get; set; }
    public float totalTime { get; set; }
    public Experimental.VFX.VFXEventAttribute vfxEventAttribute { get; }

    public void Dispose();

}

}
