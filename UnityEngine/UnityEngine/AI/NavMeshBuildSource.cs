using System;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshBuildSource
{
    public int area { get; set; }
    public Component component { get; set; }
    public AI.NavMeshBuildSourceShape shape { get; set; }
    public Vector3 size { get; set; }
    public Object sourceObject { get; set; }
    public Matrix4x4 transform { get; set; }

}

}
