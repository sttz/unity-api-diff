using System;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class NavMeshData : Object
{
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }
    public Bounds sourceBounds { get; }

    public NavMeshData();
    public NavMeshData(int agentTypeID);

}

}
