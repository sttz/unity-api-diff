using System;
using UnityEngine;

namespace UnityEngine.Experimental.AI
{

public struct NavMeshQuery : IDisposable
{
    public NavMeshQuery(Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0);

    public Experimental.AI.PathQueryStatus BeginFindPath(Experimental.AI.NavMeshLocation start, Experimental.AI.NavMeshLocation end, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null);
    public Experimental.AI.NavMeshLocation CreateLocation(Vector3 position, Experimental.AI.PolygonId polygon);
    public void Dispose();
    public Experimental.AI.PathQueryStatus EndFindPath(out int pathSize);
    public int GetAgentTypeIdForPolygon(Experimental.AI.PolygonId polygon);
    public Experimental.AI.PathQueryStatus GetEdgesAndNeighbors(Experimental.AI.PolygonId node, Unity.Collections.NativeSlice<Vector3> edgeVertices, Unity.Collections.NativeSlice<Experimental.AI.PolygonId> neighbors, Unity.Collections.NativeSlice<byte> edgeIndices, out int verticesCount, out int neighborsCount);
    public int GetPathResult(Unity.Collections.NativeSlice<Experimental.AI.PolygonId> path);
    public Experimental.AI.NavMeshPolyTypes GetPolygonType(Experimental.AI.PolygonId polygon);
    public bool GetPortalPoints(Experimental.AI.PolygonId polygon, Experimental.AI.PolygonId neighbourPolygon, out Vector3 left, out Vector3 right);
    public bool IsValid(Experimental.AI.PolygonId polygon);
    public bool IsValid(Experimental.AI.NavMeshLocation location);
    public Experimental.AI.NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1);
    public Experimental.AI.NavMeshLocation MoveLocation(Experimental.AI.NavMeshLocation location, Vector3 target, int areaMask = -1);
    public void MoveLocations(Unity.Collections.NativeSlice<Experimental.AI.NavMeshLocation> locations, Unity.Collections.NativeSlice<Vector3> targets, Unity.Collections.NativeSlice<int> areaMasks);
    public void MoveLocationsInSameAreas(Unity.Collections.NativeSlice<Experimental.AI.NavMeshLocation> locations, Unity.Collections.NativeSlice<Vector3> targets, int areaMask = -1);
    public Matrix4x4 PolygonLocalToWorldMatrix(Experimental.AI.PolygonId polygon);
    public Matrix4x4 PolygonWorldToLocalMatrix(Experimental.AI.PolygonId polygon);
    public Experimental.AI.PathQueryStatus Raycast(out AI.NavMeshHit hit, Experimental.AI.NavMeshLocation start, Vector3 targetPosition, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null);
    public Experimental.AI.PathQueryStatus Raycast(out AI.NavMeshHit hit, Unity.Collections.NativeSlice<Experimental.AI.PolygonId> path, out int pathCount, Experimental.AI.NavMeshLocation start, Vector3 targetPosition, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null);
    public Experimental.AI.PathQueryStatus UpdateFindPath(int iterations, out int iterationsPerformed);

}

}
