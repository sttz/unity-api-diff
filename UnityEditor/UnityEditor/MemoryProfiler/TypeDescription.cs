using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{

public struct TypeDescription
{
    public int arrayRank { get; }
    public string assembly { get; }
    public int baseOrElementTypeIndex { get; }
    public UnityEditor.MemoryProfiler.FieldDescription[] fields { get; }
    public bool isArray { get; }
    public bool isValueType { get; }
    public string name { get; }
    public int size { get; }
    public byte[] staticFieldBytes { get; }
    public int typeIndex { get; }
    public ulong typeInfoAddress { get; }

    public TypeDescription(string name, string assembly, UnityEditor.MemoryProfiler.FieldDescription[] fields, byte[] staticFieldBytes, int baseOrElementTypeIndes, int size, ulong typeInfoAddress, int typeIndex, TypeFlags flags);

    public enum TypeFlags
    {
        kNone = 0,
        kValueType = 1,
        kArray = 2,
        kArrayRankMask = -65536,
    }

}

}
