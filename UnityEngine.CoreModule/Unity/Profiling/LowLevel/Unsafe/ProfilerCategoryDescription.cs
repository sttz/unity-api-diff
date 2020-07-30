using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{

public struct ProfilerCategoryDescription
{
    public Color32 Color;
    public ushort Id;
    public byte NameUtf8;
    public int NameUtf8Len;

    public string Name { get; }

}

}
