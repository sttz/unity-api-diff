using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GraphicsBuffer : IDisposable
{
    public int count { get; }
    public int stride { get; }

    public GraphicsBuffer(Target target, int count, int stride);

    public void Dispose();
    public IntPtr GetNativeBufferPtr();
    public bool IsValid();
    public void Release();
    public void SetData(Array data);
    public void SetData(System.Collections.Generic.List<T> data);
    public void SetData(Unity.Collections.NativeArray<T> data);
    public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
    public void SetData(System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
    public void SetData(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);

    public enum Target
    {
        Index = 2,
    }

}

}
