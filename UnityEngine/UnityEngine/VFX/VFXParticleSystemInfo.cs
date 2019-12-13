using System;
using UnityEngine;

namespace UnityEngine.VFX
{

public struct VFXParticleSystemInfo
{
    public uint aliveCount;
    public Bounds bounds;
    public uint capacity;
    public bool sleeping;

    public VFXParticleSystemInfo(uint aliveCount, uint capacity, bool sleeping, Bounds bounds);

}

}
