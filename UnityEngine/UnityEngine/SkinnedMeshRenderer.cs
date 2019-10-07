using System;
using UnityEngine;

namespace UnityEngine
{

public class SkinnedMeshRenderer : Renderer
{
    public Transform[] bones { get; set; }
    public bool forceMatrixRecalculationPerRender { get; set; }
    public Bounds localBounds { get; set; }
    public SkinQuality quality { get; set; }
    public Transform rootBone { get; set; }
    public Mesh sharedMesh { get; set; }
    public bool skinnedMotionVectors { get; set; }
    public bool updateWhenOffscreen { get; set; }

    public SkinnedMeshRenderer();

    public void BakeMesh(Mesh mesh);
    public float GetBlendShapeWeight(int index);
    public void SetBlendShapeWeight(int index, float value);

}

}
