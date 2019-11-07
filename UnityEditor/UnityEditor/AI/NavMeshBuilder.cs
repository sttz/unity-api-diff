using System;
using UnityEngine;

namespace UnityEditor.AI
{

public sealed class NavMeshBuilder
{
    static public bool isRunning { get; }
    static public Object navMeshSettingsObject { get; }

    static public void BuildNavMesh();
    static public void BuildNavMeshAsync();
    static public void BuildNavMeshForMultipleScenes(string[] paths);
    static public void Cancel();
    static public void ClearAllNavMeshes();
    static public void CollectSourcesInStage(Bounds includedWorldBounds, int includedLayerMask, AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<AI.NavMeshBuildMarkup> markups, SceneManagement.Scene stageProxy, System.Collections.Generic.List<AI.NavMeshBuildSource> results);
    static public void CollectSourcesInStage(Transform root, int includedLayerMask, AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<AI.NavMeshBuildMarkup> markups, SceneManagement.Scene stageProxy, System.Collections.Generic.List<AI.NavMeshBuildSource> results);

    public NavMeshBuilder();

}

}
