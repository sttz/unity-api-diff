using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class PhysicsVisualizationSettings
{
    static public float baseAlpha { get; set; }
    static public float colorVariance { get; set; }
    static public bool devOptions { get; set; }
    static public int dirtyCount { get; }
    static public float dotAlpha { get; set; }
    static public bool enableMouseSelect { get; set; }
    static public FilterWorkflow filterWorkflow { get; set; }
    static public bool forceDot { get; set; }
    static public bool forceOverdraw { get; set; }
    static public Color kinematicColor { get; set; }
    static public Color rigidbodyColor { get; set; }
    static public bool showCollisionGeometry { get; set; }
    static public Color sleepingBodyColor { get; set; }
    static public Color staticColor { get; set; }
    static public int terrainTilesMax { get; set; }
    static public Color triggerColor { get; set; }
    static public bool useSceneCam { get; set; }
    static public float viewDistance { get; set; }

    static public void ClearMouseHighlight();
    static public void DeinitDebugDraw();
    static public bool GetShowBoxColliders(FilterWorkflow filterWorkflow);
    static public bool GetShowCapsuleColliders(FilterWorkflow filterWorkflow);
    static public bool GetShowCollisionLayer(FilterWorkflow filterWorkflow, int layer);
    static public int GetShowCollisionLayerMask(FilterWorkflow filterWorkflow);
    static public bool GetShowKinematicBodies(FilterWorkflow filterWorkflow);
    static public bool GetShowMeshColliders(FilterWorkflow filterWorkflow, MeshColliderType colliderType);
    static public bool GetShowRigidbodies(FilterWorkflow filterWorkflow);
    static public bool GetShowSleepingBodies(FilterWorkflow filterWorkflow);
    static public bool GetShowSphereColliders(FilterWorkflow filterWorkflow);
    static public bool GetShowStaticColliders(FilterWorkflow filterWorkFlow);
    static public bool GetShowTerrainColliders(FilterWorkflow filterWorkflow);
    static public bool GetShowTriggers(FilterWorkflow filterWorkflow);
    static public bool HasMouseHighlight();
    static public void InitDebugDraw();
    static public GameObject PickClosestGameObject(Camera cam, int layers, Vector2 position, GameObject[] ignore, GameObject[] filter, out int materialIndex);
    static public void Reset();
    static public void SetShowBoxColliders(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowCapsuleColliders(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowCollisionLayer(FilterWorkflow filterWorkflow, int layer, bool show);
    static public void SetShowCollisionLayerMask(FilterWorkflow filterWorkflow, int mask);
    static public void SetShowForAllFilters(FilterWorkflow filterWorkflow, bool selected);
    static public void SetShowKinematicBodies(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowMeshColliders(FilterWorkflow filterWorkflow, MeshColliderType colliderType, bool show);
    static public void SetShowRigidbodies(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowSleepingBodies(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowSphereColliders(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowStaticColliders(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowTerrainColliders(FilterWorkflow filterWorkflow, bool show);
    static public void SetShowTriggers(FilterWorkflow filterWorkflow, bool show);
    static public void UpdateMouseHighlight(Vector2 screenPos);

    public enum FilterWorkflow
    {
        HideSelectedItems = 0,
        ShowSelectedItems = 1,
    }

    public enum MeshColliderType
    {
        Convex = 0,
        NonConvex = 1,
    }

}

}
