using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeGroupBranch : TreeEditor.TreeGroup
{
    public float breakingChance;
    public Vector2 breakingSpot;
    public float capSmoothing;
    public AnimationCurve crinkCurve;
    public float crinklyness;
    public float flareHeight;
    public float flareNoise;
    public float flareSize;
    public int frondCount;
    public float frondCrease;
    public AnimationCurve frondCurve;
    public Vector2 frondRange;
    public float frondRotation;
    public float frondWidth;
    public GeometryMode geometryMode;
    public Vector2 height;
    public float lodQualityMultiplier;
    public Material materialBranch;
    public Material materialBreak;
    public Material materialFrond;
    public float noise;
    public AnimationCurve noiseCurve;
    public float noiseScaleU;
    public float noiseScaleV;
    public float radius;
    public AnimationCurve radiusCurve;
    public bool radiusMode;
    public float seekBlend;
    public AnimationCurve seekCurve;
    public float weldHeight;
    public float weldSpreadBottom;
    public float weldSpreadTop;

    public TreeGroupBranch();

    public void BuildAOSpheres(List<TreeEditor.TreeAOSphere> aoSpheres);
    public float GetRadiusAtTime(TreeEditor.TreeNode node, float time, bool includeModifications);
    public void UpdateMatrix();
    public void UpdateMesh(List<TreeEditor.TreeMaterial> materials, List<TreeEditor.TreeVertex> verts, List<TreeEditor.TreeTriangle> tris, List<TreeEditor.TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
    public void UpdateParameters();
    public void UpdateSpline(TreeEditor.TreeNode node);
    public void UpdateSplines();

    public enum GeometryMode
    {
        Branch = 0,
        BranchFrond = 1,
        Frond = 2,
    }

}

}
