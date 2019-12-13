using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct MemorySection
{
    public byte[] bytes { get; }
    public ulong startAddress { get; }

    public MemorySection(byte[] bytes, ulong startAddress);

}

}