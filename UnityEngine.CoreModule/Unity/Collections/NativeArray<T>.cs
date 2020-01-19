using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections
{

public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEquatable<Unity.Collections.NativeArray<T>>, IEnumerable
{
    static public void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
    static public void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
    static public void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
    static public void Copy(T[] src, Unity.Collections.NativeArray<T> dst, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
    static public void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);

    public bool IsCreated { get; }
    public T this[int index] { get; set; }
    public int Length { get; }

    public NativeArray(T[] array, Unity.Collections.Allocator allocator);
    public NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);
    public NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options = 1);

    public void CopyFrom(T[] array);
    public void CopyFrom(Unity.Collections.NativeArray<T> array);
    public void CopyTo(T[] array);
    public void CopyTo(Unity.Collections.NativeArray<T> array);
    public void Dispose();
    public bool Equals(object obj);
    public bool Equals(Unity.Collections.NativeArray<T> other);
    public Enumerator<T> GetEnumerator();
    public int GetHashCode();
    public T[] ToArray();

    public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
    {
        public T Current { get; }

        public Enumerator(Unity.Collections.NativeArray<T> array);

        public void Dispose();
        public bool MoveNext();
        public void Reset();

    }

}

}
