using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public struct SerializedLocation
{
    public string fileName { get; }
    public ulong offset { get; }
    public ulong size { get; }

}

}
