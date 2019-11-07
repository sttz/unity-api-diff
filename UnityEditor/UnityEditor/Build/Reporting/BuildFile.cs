using System;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public struct BuildFile
{
    public string path { get; }
    public string role { get; }
    public ulong size { get; }

    public string ToString();

}

}
