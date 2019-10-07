using System;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class NavMeshAgent : Behaviour
{
    public float acceleration { get; set; }
    public int agentTypeID { get; set; }
    public float angularSpeed { get; set; }
    public int areaMask { get; set; }
    public bool autoBraking { get; set; }
    public bool autoRepath { get; set; }
    public bool autoTraverseOffMeshLink { get; set; }
    public int avoidancePriority { get; set; }
    public float baseOffset { get; set; }
    public AI.OffMeshLinkData currentOffMeshLinkData { get; }
    public Vector3 desiredVelocity { get; }
    public Vector3 destination { get; set; }
    public bool hasPath { get; }
    public float height { get; set; }
    public bool isOnNavMesh { get; }
    public bool isOnOffMeshLink { get; }
    public bool isPathStale { get; }
    public bool isStopped { get; set; }
    public Object navMeshOwner { get; }
    public AI.OffMeshLinkData nextOffMeshLinkData { get; }
    public Vector3 nextPosition { get; set; }
    public AI.ObstacleAvoidanceType obstacleAvoidanceType { get; set; }
    public AI.NavMeshPath path { get; set; }
    public Vector3 pathEndPosition { get; }
    public bool pathPending { get; }
    public AI.NavMeshPathStatus pathStatus { get; }
    public float radius { get; set; }
    public float remainingDistance { get; }
    public float speed { get; set; }
    public Vector3 steeringTarget { get; }
    public float stoppingDistance { get; set; }
    public bool updatePosition { get; set; }
    public bool updateRotation { get; set; }
    public bool updateUpAxis { get; set; }
    public Vector3 velocity { get; set; }
    public int walkableMask { get; set; }

    public NavMeshAgent();

    public void ActivateCurrentOffMeshLink(bool activated);
    public bool CalculatePath(Vector3 targetPosition, AI.NavMeshPath path);
    public void CompleteOffMeshLink();
    public bool FindClosestEdge(out AI.NavMeshHit hit);
    public float GetAreaCost(int areaIndex);
    public float GetLayerCost(int layer);
    public void Move(Vector3 offset);
    public bool Raycast(Vector3 targetPosition, out AI.NavMeshHit hit);
    public void ResetPath();
    public void Resume();
    public bool SamplePathPosition(int areaMask, float maxDistance, out AI.NavMeshHit hit);
    public void SetAreaCost(int areaIndex, float areaCost);
    public bool SetDestination(Vector3 target);
    public void SetLayerCost(int layer, float cost);
    public bool SetPath(AI.NavMeshPath path);
    public void Stop();
    public void Stop(bool stopUpdates);
    public bool Warp(Vector3 newPosition);

}

}
