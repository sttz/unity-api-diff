using System;
using UnityEngine;

namespace UnityEditor
{

public static class Lightmapping
{
    static public OnCompletedFunction completed;

    static public bool bakedGI { get; set; }
    static public float bounceBoost { get; set; }
    static public float buildProgress { get; }
    static public GIWorkflowMode giWorkflowMode { get; set; }
    static public float indirectOutputScale { get; set; }
    static public bool isRunning { get; }
    static public UnityEditor.LightingDataAsset lightingDataAsset { get; set; }
    static public UnityEditor.LightmapSnapshot lightmapSnapshot { get; set; }
    static public bool realtimeGI { get; set; }

    static public event OnStartedFunction started;

    static public bool Bake();
    static public bool BakeAsync();
    static public bool BakeLightProbesOnly();
    static public bool BakeLightProbesOnlyAsync();
    static public void BakeMultipleScenes(string[] paths);
    static public bool BakeReflectionProbe(ReflectionProbe probe, string path);
    static public bool BakeSelected();
    static public bool BakeSelectedAsync();
    static public void Cancel();
    static public void Clear();
    static public void ClearDiskCache();
    static public void ClearLightingDataAsset();
    static public void ForceStop();
    static public void GetTerrainGIChunks(Terrain terrain, int numChunksX, int numChunksY);
    static public void Tetrahedralize(Vector3[] positions, out int outIndices, out Vector3 outPositions);

    public enum GIWorkflowMode
    {
        Iterative = 0,
        OnDemand = 1,
        Legacy = 2,
    }

    public delegate void OnStartedFunction();

    public delegate void OnCompletedFunction();

}

}
