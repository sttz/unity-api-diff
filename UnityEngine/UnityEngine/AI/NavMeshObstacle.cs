using System;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class NavMeshObstacle : Behaviour
{
    public bool carveOnlyStationary { get; set; }
    public bool carving { get; set; }
    public float carvingMoveThreshold { get; set; }
    public float carvingTimeToStationary { get; set; }
    public Vector3 center { get; set; }
    public float height { get; set; }
    public float radius { get; set; }
    public AI.NavMeshObstacleShape shape { get; set; }
    public Vector3 size { get; set; }
    public Vector3 velocity { get; set; }

    public NavMeshObstacle();

}

}
