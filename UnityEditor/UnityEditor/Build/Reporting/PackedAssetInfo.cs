using System;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{

public struct PackedAssetInfo
{
    public long id { get; }
    public ulong offset { get; }
    public ulong packedSize { get; }
    public UnityEditor.GUID sourceAssetGUID { get; }
    public string sourceAssetPath { get; }
    public Type type { get; }

}

}
