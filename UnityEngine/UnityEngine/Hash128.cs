using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
    static public Hash128 Compute(string hashString);
    static public Hash128 Parse(string hashString);

    public bool isValid { get; }

    public Hash128(ulong u64_0, ulong u64_1);
    public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);

    public int CompareTo(object obj);
    public int CompareTo(Hash128 rhs);
    public bool Equals(object obj);
    public bool Equals(Hash128 obj);
    public int GetHashCode();
    public string ToString();

}

}
