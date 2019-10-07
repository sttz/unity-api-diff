using System;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class NavMeshPath
{
    public Vector3[] corners { get; }
    public AI.NavMeshPathStatus status { get; }

    public NavMeshPath();

    public void ClearCorners();
    public int GetCornersNonAlloc(out Vector3[] results);

}

}
