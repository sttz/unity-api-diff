using System;
using UnityEngine;

namespace TreeEditor
{

public class TreeAOSphere
{
    public float area;
    public float density;
    public bool flag;
    public Vector3 position;
    public float radius;

    public TreeAOSphere(Vector3 pos, float radius, float density);

    public float PointOcclusion(Vector3 pos, Vector3 nor);

}

}
