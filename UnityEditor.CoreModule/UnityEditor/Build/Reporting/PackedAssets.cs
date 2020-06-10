using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public sealed class PackedAssets : Object
{
    public UnityEditor.Build.Reporting.PackedAssetInfo[] contents { get; }
    public uint file { get; }
    public ulong overhead { get; }
    public string shortPath { get; }

    public PackedAssets();

}

}
