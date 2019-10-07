using System;
using UnityEngine;

namespace UnityEngine
{

public struct RangeInt
{
    public int length;
    public int start;

    public int end { get; }

    public RangeInt(int start, int length);

}

}
