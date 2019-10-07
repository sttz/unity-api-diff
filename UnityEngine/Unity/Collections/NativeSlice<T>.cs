using System;
using UnityEngine;

namespace Unity.Collections
{

public struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IEquatable<Unity.Collections.NativeSlice<T>>
{
    public T this[int index] { get; set; }
    public int Length { get; }
    public int Stride { get; }

    public NativeSlice(Unity.Collections.NativeSlice<T> slice, int start);
    public NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
    public NativeSlice(Unity.Collections.NativeArray<T> array);
    public NativeSlice(Unity.Collections.NativeArray<T> array, int start);
    public NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);

    public void CopyFrom(Unity.Collections.NativeSlice<T> slice);
    public void CopyFrom(T[] array);
    public void CopyTo(Unity.Collections.NativeArray<T> array);
    public void CopyTo(T[] array);
    public bool Equals(Unity.Collections.NativeSlice<T> other);
    public bool Equals(object obj);
    public Enumerator<T> GetEnumerator();
    public int GetHashCode();
    public Unity.Collections.NativeSlice<U> SliceConvert();
    public Unity.Collections.NativeSlice<U> SliceWithStride(int offset);
    public Unity.Collections.NativeSlice<U> SliceWithStride();
    public T[] ToArray();

    public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, IDisposable
    {
        public T Current { get; }

        public Enumerator(Unity.Collections.NativeSlice<T> array);

        public void Dispose();
        public bool MoveNext();
        public void Reset();

    }

}

}
