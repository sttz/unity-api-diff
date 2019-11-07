using System;
using UnityEngine;

namespace TreeEditor
{

public class TreeGroup
{
    static protected float GenerateBendBillboardNormalFactor;
    static protected float GenerateBendNormalFactor;
    static protected bool GenerateDoubleSidedGeometry;

    static protected float ComputeAmbientOcclusion(Vector3 pos, Vector3 nor, System.Collections.Generic.List<TreeEditor.TreeAOSphere> aoSpheres, float aoDensity);
    static protected Vector4 CreateTangent(TreeEditor.TreeNode node, Quaternion rot, Vector3 normal);
    static protected int GetMaterialIndex(Material m, System.Collections.Generic.List<TreeEditor.TreeMaterial> materials, bool tileV);

    public float animationEdge;
    public float animationPrimary;
    public float animationSecondary;
    public int[] childGroupIDs;
    public AnimationCurve distributionCurve;
    public int distributionFrequency;
    public DistributionMode distributionMode;
    public int distributionNodes;
    public float distributionPitch;
    public AnimationCurve distributionPitchCurve;
    public float distributionScale;
    public AnimationCurve distributionScaleCurve;
    public float distributionTwirl;
    public int lockFlags;
    public int[] nodeIDs;
    public int parentGroupID;
    public int seed;
    public bool showAnimationProps;
    public bool visible;

    public int uniqueID { get; set; }

    public TreeGroup();

    public void BuildAOSpheres(System.Collections.Generic.List<TreeEditor.TreeAOSphere> aoSpheres);
    public bool CanHaveSubGroups();
    public bool CheckExternalChanges();
    public Vector2 ComputeWindFactor(TreeEditor.TreeNode node, float offset);
    public float GetRadiusAtTime(TreeEditor.TreeNode node, float t, bool includeModifications);
    public Matrix4x4 GetRootMatrix();
    public float GetRootSpread();
    public void Lock();
    public void Unlock();
    public void UpdateDistribution(bool completeUpdate, bool updateSubGroups);
    public void UpdateFrequency(TreeEditor.TreeData owner);
    public void UpdateMatrix();
    public void UpdateMesh(System.Collections.Generic.List<TreeEditor.TreeMaterial> materials, System.Collections.Generic.List<TreeEditor.TreeVertex> verts, System.Collections.Generic.List<TreeEditor.TreeTriangle> tris, System.Collections.Generic.List<TreeEditor.TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
    public void UpdateParameters();
    public void UpdateSeed();

    public enum LockFlag
    {
        LockPosition = 1,
        LockAlignment = 2,
        LockShape = 4,
    }

    public enum BuildFlag
    {
        BuildAmbientOcclusion = 1,
        BuildWeldParts = 2,
    }

    public enum DistributionMode
    {
        Random = 0,
        Alternate = 1,
        Opposite = 2,
        Whorled = 3,
    }

}

}
