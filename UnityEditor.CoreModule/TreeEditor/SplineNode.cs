using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class SplineNode
{
    public Vector3 normal;
    public Vector3 point;
    public Quaternion rot;
    public Vector3 tangent;
    public float time;

    public SplineNode(TreeEditor.SplineNode o);
    public SplineNode(Vector3 p, float t);

}

}
