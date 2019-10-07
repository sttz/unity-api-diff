using System;
using UnityEngine;

namespace UnityEngine.AI
{

public static class NavMesh
{
    static public int AllAreas = -1;
    static public OnNavMeshPreUpdate onPreUpdate;

    static public float avoidancePredictionTime { get; set; }
    static public int pathfindingIterationsPerFrame { get; set; }

    static public AI.NavMeshLinkInstance AddLink(AI.NavMeshLinkData link);
    static public AI.NavMeshLinkInstance AddLink(AI.NavMeshLinkData link, Vector3 position, Quaternion rotation);
    static public AI.NavMeshDataInstance AddNavMeshData(AI.NavMeshData navMeshData);
    static public AI.NavMeshDataInstance AddNavMeshData(AI.NavMeshData navMeshData, Vector3 position, Quaternion rotation);
    static public void AddOffMeshLinks();
    static public bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, AI.NavMeshPath path);
    static public bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, AI.NavMeshQueryFilter filter, AI.NavMeshPath path);
    static public AI.NavMeshTriangulation CalculateTriangulation();
    static public AI.NavMeshBuildSettings CreateSettings();
    static public bool FindClosestEdge(Vector3 sourcePosition, out AI.NavMeshHit hit, int areaMask);
    static public bool FindClosestEdge(Vector3 sourcePosition, out AI.NavMeshHit hit, AI.NavMeshQueryFilter filter);
    static public float GetAreaCost(int areaIndex);
    static public int GetAreaFromName(string areaName);
    static public float GetLayerCost(int layer);
    static public int GetNavMeshLayerFromName(string layerName);
    static public AI.NavMeshBuildSettings GetSettingsByID(int agentTypeID);
    static public AI.NavMeshBuildSettings GetSettingsByIndex(int index);
    static public int GetSettingsCount();
    static public string GetSettingsNameFromID(int agentTypeID);
    static public bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out AI.NavMeshHit hit, int areaMask);
    static public bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out AI.NavMeshHit hit, AI.NavMeshQueryFilter filter);
    static public void RemoveAllNavMeshData();
    static public void RemoveLink(AI.NavMeshLinkInstance handle);
    static public void RemoveNavMeshData(AI.NavMeshDataInstance handle);
    static public void RemoveSettings(int agentTypeID);
    static public void RestoreNavMesh();
    static public bool SamplePosition(Vector3 sourcePosition, out AI.NavMeshHit hit, float maxDistance, int areaMask);
    static public bool SamplePosition(Vector3 sourcePosition, out AI.NavMeshHit hit, float maxDistance, AI.NavMeshQueryFilter filter);
    static public void SetAreaCost(int areaIndex, float cost);
    static public void SetLayerCost(int layer, float cost);
    static public void Triangulate(out Vector3 vertices, out int indices);

    public delegate void OnNavMeshPreUpdate();

}

}
