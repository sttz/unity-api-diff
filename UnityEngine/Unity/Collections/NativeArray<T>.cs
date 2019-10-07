using System;
using UnityEngine;

namespace Unity.Collections
{

public struct NativeArray<T> : IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IEquatable<Unity.Collections.NativeArray<T>>
{
    static public void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
    static public void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
    static public void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
    static public void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
    static public void Copy(T[] src, Unity.Collections.NativeArray<T> dst, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
    static public void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
    static public void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);

    public bool IsCreated { get; }
    public T this[int index] { get; set; }
    public int Length { get; }

    public NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options = 1);
    public NativeArray(T[] array, Unity.Collections.Allocator allocator);
    public NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);

    public void CopyFrom(T[] array);
    public void CopyFrom(Unity.Collections.NativeArray<T> array);
    public void CopyTo(T[] array);
    public void CopyTo(Unity.Collections.NativeArray<T> array);
    public void Dispose();
    public Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
    public bool Equals(Unity.Collections.NativeArray<T> other);
    public bool Equals(object obj);
    public Enumerator<T> GetEnumerator();
    public int GetHashCode();
    public Unity.Collections.NativeArray<T> GetSubArray(int start, int length);
    public Unity.Collections.NativeArray<U> Reinterpret();
    public Unity.Collections.NativeArray<U> Reinterpret(int expectedTypeSize);
    public U ReinterpretLoad(int sourceIndex);
    public void ReinterpretStore(int destIndex, U data);
    public T[] ToArray();

    public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, IDisposable
    {
        public T Current { get; }

        public Enumerator(Unity.Collections.NativeArray<T> array);

        public void Dispose();
        public bool MoveNext();
        public void Reset();

    }

}

}
