using System;
using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{

public class ArrayEntries<T>
{
    public void GetEntries(uint indexStart, uint numEntries, T[]& dataOut);
    public uint GetNumEntries();

}

}
