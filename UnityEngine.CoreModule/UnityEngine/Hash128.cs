using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
    static public Hash128 Compute(string data);
    static public Hash128 Compute(int val);
    static public Hash128 Compute(float val);
    static public Hash128 Compute(void data, ulong size);
    static public Hash128 Compute<T>(List<T> data);
    static public Hash128 Compute<T>(T[] data);
    static public Hash128 Compute<T>(Unity.Collections.NativeArray<T> data);
    static public Hash128 Compute<T>(T val);
    static public Hash128 Compute<T>(List<T> data, int start, int count);
    static public Hash128 Compute<T>(T[] data, int start, int count);
    static public Hash128 Compute<T>(Unity.Collections.NativeArray<T> data, int start, int count);
    static public Hash128 Parse(string hashString);

    public bool isValid { get; }

    public Hash128(ulong u64_0, ulong u64_1);
    public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);

    public void Append(string data);
    public void Append(int val);
    public void Append(float val);
    public void Append(void data, ulong size);
    public void Append<T>(List<T> data);
    public void Append<T>(T[] data);
    public void Append<T>(Unity.Collections.NativeArray<T> data);
    public void Append<T>(T val);
    public void Append<T>(List<T> data, int start, int count);
    public void Append<T>(T[] data, int start, int count);
    public void Append<T>(Unity.Collections.NativeArray<T> data, int start, int count);
    public int CompareTo(object obj);
    public int CompareTo(Hash128 rhs);
    public bool Equals(object obj);
    public bool Equals(Hash128 obj);
    public int GetHashCode();
    public string ToString();

}

}
