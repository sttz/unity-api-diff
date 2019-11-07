using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct FieldDescription
{
    public bool isStatic { get; }
    public string name { get; }
    public int offset { get; }
    public int typeIndex { get; }

    public FieldDescription(string name, int offset, int typeIndex, bool isStatic);

}

}
