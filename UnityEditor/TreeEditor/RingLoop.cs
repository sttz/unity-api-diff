using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class RingLoop
{
    static public void SetNoiseSeed(int seed);

    public float baseOffset;
    public float radius;

    public RingLoop();

    public void BuildVertices(List<TreeEditor.TreeVertex> verts);
    public void Cap(float sphereFactor, float noise, int mappingMode, float mappingScale, List<TreeEditor.TreeVertex> verts, List<TreeEditor.TreeTriangle> tris, int materialIndex);
    public TreeEditor.RingLoop Clone();
    public void Connect(TreeEditor.RingLoop other, List<TreeEditor.TreeTriangle> tris, int materialIndex, bool flipTris, bool lowres);
    public void Reset(float r, Matrix4x4 m, float bOffset, int segs);
    public void SetAnimationProperties(float primaryFactor, float secondaryFactor, float edgeFactor, float phase);
    public void SetFlares(float radius, float noise);
    public void SetNoise(float scale, float scaleU, float scaleV);
    public void SetSpread(float top, float bottom);
    public void SetSurfaceAngle(float angleDeg);

}

}
