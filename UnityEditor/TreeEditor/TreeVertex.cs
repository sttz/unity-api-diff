using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeVertex
{
    public Color color;
    public bool flag;
    public Vector3 nor;
    public Vector3 pos;
    public Vector4 tangent;
    public Vector2 uv0;
    public Vector2 uv1;

    public TreeVertex();

    public void Lerp4(TreeEditor.TreeVertex[] tv, Vector2 factor);
    public void SetAmbientOcclusion(float ao);
    public void SetAnimationProperties(float primaryFactor, float secondaryFactor, float edgeFactor, float phase);

}

}
