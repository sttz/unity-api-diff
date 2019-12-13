using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GraphicsBuffer : IDisposable
{
    static public void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes);
    static public void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes);
    static public void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes);
    static public void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes);

    public int count { get; }
    public int stride { get; }

    public GraphicsBuffer(Target target, int count, int stride);

    public void Dispose();
    public void GetData(Array data);
    public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
    public IntPtr GetNativeBufferPtr();
    public bool IsValid();
    public void Release();
    public void SetCounterValue(uint counterValue);
    public void SetData(Array data);
    public void SetData(System.Collections.Generic.List<T> data);
    public void SetData(Unity.Collections.NativeArray<T> data);
    public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
    public void SetData(System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
    public void SetData(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);

    public enum Target
    {
        Vertex = 1,
        Index = 2,
        Structured = 16,
        Raw = 32,
        Append = 64,
        Counter = 128,
        IndirectArguments = 256,
        Constant = 512,
    }

}

}
