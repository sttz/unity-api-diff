using System;
using UnityEngine;

namespace UnityEngine.AI
{

public static class NavMeshBuilder
{
    static public AI.NavMeshData BuildNavMeshData(AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<AI.NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation);
    static public void Cancel(AI.NavMeshData data);
    static public void CollectSources(Bounds includedWorldBounds, int includedLayerMask, AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<AI.NavMeshBuildSource> results);
    static public void CollectSources(Transform root, int includedLayerMask, AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<AI.NavMeshBuildSource> results);
    static public bool UpdateNavMeshData(AI.NavMeshData data, AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<AI.NavMeshBuildSource> sources, Bounds localBounds);
    static public AsyncOperation UpdateNavMeshDataAsync(AI.NavMeshData data, AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<AI.NavMeshBuildSource> sources, Bounds localBounds);

}

}
