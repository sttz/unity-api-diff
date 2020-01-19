using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ComputeBuffer : IDisposable
{
    static public void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes);

    public int count { get; }
    public string name { set; }
    public int stride { get; }

    public ComputeBuffer(int count, int stride);
    public ComputeBuffer(int count, int stride, ComputeBufferType type);
    public ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage);

    public void Dispose();
    public void GetData(Array data);
    public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
    public IntPtr GetNativeBufferPtr();
    public bool IsValid();
    public void Release();
    public void SetCounterValue(uint counterValue);
    public void SetData(Array data);
    public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
    public void SetData<T>(List<T> data);
    public void SetData<T>(Unity.Collections.NativeArray<T> data);
    public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
    public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count);

}

}
