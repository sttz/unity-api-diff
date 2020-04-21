using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class UnityStats
{
    static public int animationComponentsPlaying { get; }
    static public int animatorComponentsPlaying { get; }
    static public float audioClippingAmount { get; }
    static public float audioDSPLoad { get; }
    static public float audioLevel { get; }
    static public float audioStreamLoad { get; }
    static public int batches { get; }
    static public int drawCalls { get; }
    static public int dynamicBatchedDrawCalls { get; }
    static public int dynamicBatches { get; }
    static public float frameTime { get; }
    static public int ibUploadBytes { get; }
    static public int ibUploads { get; }
    static public int instancedBatchedDrawCalls { get; }
    static public int instancedBatches { get; }
    static public int renderTextureBytes { get; }
    static public int renderTextureChanges { get; }
    static public int renderTextureCount { get; }
    static public float renderTime { get; }
    static public int screenBytes { get; }
    static public string screenRes { get; }
    static public int setPassCalls { get; }
    static public int shadowCasters { get; }
    static public int staticBatchedDrawCalls { get; }
    static public int staticBatches { get; }
    static public int triangles { get; }
    static public int usedTextureCount { get; }
    static public int usedTextureMemorySize { get; }
    static public int vboTotal { get; }
    static public int vboTotalBytes { get; }
    static public int vboUploadBytes { get; }
    static public int vboUploads { get; }
    static public int vertices { get; }
    static public int visibleSkinnedMeshes { get; }

    public UnityStats();

}

}
