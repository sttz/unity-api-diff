using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public struct BuildFile
{
    public uint id { get; }
    public string path { get; }
    public string role { get; }
    public ulong size { get; }

    public string ToString();

}

}
