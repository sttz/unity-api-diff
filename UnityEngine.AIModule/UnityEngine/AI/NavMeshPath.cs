using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.AI
{

public sealed class NavMeshPath
{
    public Vector3[] corners { get; }
    public AI.NavMeshPathStatus status { get; }

    public NavMeshPath();

    public void ClearCorners();
    public int GetCornersNonAlloc(Vector3[] results);

}

}
