using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections
{

public struct NativeSlice<T> : IEnumerable<T>, IEquatable<Unity.Collections.NativeSlice<T>>, IEnumerable
{
    public T this[int index] { get; set; }
    public int Length { get; }
    public int Stride { get; }

    public NativeSlice(Unity.Collections.NativeArray<T> array);
    public NativeSlice(Unity.Collections.NativeArray<T> array, int start);
    public NativeSlice(Unity.Collections.NativeSlice<T> slice, int start);
    public NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
    public NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);

    public void CopyFrom(T[] array);
    public void CopyFrom(Unity.Collections.NativeSlice<T> slice);
    public void CopyTo(T[] array);
    public void CopyTo(Unity.Collections.NativeArray<T> array);
    public bool Equals(object obj);
    public bool Equals(Unity.Collections.NativeSlice<T> other);
    public Enumerator<T> GetEnumerator();
    public int GetHashCode();
    public Unity.Collections.NativeSlice<U> SliceConvert<U>();
    public Unity.Collections.NativeSlice<U> SliceWithStride<U>();
    public Unity.Collections.NativeSlice<U> SliceWithStride<U>(int offset);
    public T[] ToArray();

    public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
    {
        public T Current { get; }

        public Enumerator(Unity.Collections.NativeSlice<T> array);

        public void Dispose();
        public bool MoveNext();
        public void Reset();

    }

}

}
