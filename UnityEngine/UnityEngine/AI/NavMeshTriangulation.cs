using System;
using UnityEngine;

namespace UnityEngine.AI
{

public struct NavMeshTriangulation
{
    public int[] areas;
    public int[] indices;
    public Vector3[] vertices;

    public int[] layers { get; }

}

}
