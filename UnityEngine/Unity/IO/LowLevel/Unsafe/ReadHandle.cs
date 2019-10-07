using System;
using UnityEngine;

namespace Unity.IO.LowLevel.Unsafe
{

public struct ReadHandle : IDisposable
{
    public Unity.Jobs.JobHandle JobHandle { get; }
    public Unity.IO.LowLevel.Unsafe.ReadStatus Status { get; }

    public void Dispose();
    public bool IsValid();

}

}
