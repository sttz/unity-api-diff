using System;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshBuildSettings
{
    public float agentClimb { get; set; }
    public float agentHeight { get; set; }
    public float agentRadius { get; set; }
    public float agentSlope { get; set; }
    public int agentTypeID { get; set; }
    public AI.NavMeshBuildDebugSettings debug { get; set; }
    public float minRegionArea { get; set; }
    public bool overrideTileSize { get; set; }
    public bool overrideVoxelSize { get; set; }
    public int tileSize { get; set; }
    public float voxelSize { get; set; }

    public string[] ValidationReport(Bounds buildBounds);

}

}
