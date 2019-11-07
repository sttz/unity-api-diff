using System;
using UnityEngine;

namespace UnityEditor.Profiling
{

public abstract class FrameDataView : IDisposable
{
    static public int invalidMarkerId = -1;

    protected IntPtr m_Ptr;

    public float frameFps { get; }
    public float frameGpuTimeMs { get; }
    public ulong frameGpuTimeNs { get; }
    public int frameIndex { get; }
    public double frameStartTimeMs { get; }
    public ulong frameStartTimeNs { get; }
    public float frameTimeMs { get; }
    public ulong frameTimeNs { get; }
    public int maxDepth { get; }
    public int sampleCount { get; }
    public string threadGroupName { get; }
    public ulong threadId { get; }
    public int threadIndex { get; }
    public string threadName { get; }
    public bool valid { get; }

    protected FrameDataView();

    public void Dispose();
    public Unity.Collections.NativeArray<T> GetFrameMetaData(Guid id, int tag);
    public Unity.Collections.NativeArray<T> GetFrameMetaData(Guid id, int tag, int index);
    public int GetFrameMetaDataCount(Guid id, int tag);
    public ushort GetMarkerCategoryIndex(int markerId);
    public Unity.Profiling.LowLevel.MarkerFlags GetMarkerFlags(int markerId);
    public int GetMarkerId(string markerName);
    public string GetMarkerName(int markerId);
    public MethodInfo ResolveMethodInfo(ulong addr);

    public struct MethodInfo
    {
        public string methodName;
        public uint sourceFileLine;
        public string sourceFileName;

    }

}

}
