using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct Connection
{
    public int from { get; set; }
    public int to { get; set; }

    public Connection(int from, int to);

}

}
