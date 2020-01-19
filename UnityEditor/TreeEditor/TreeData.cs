using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeData : ScriptableObject
{
    static public int GetAdaptiveHeightSegments(float h, float adaptiveQuality);
    static public int GetAdaptiveRadialSegments(float r, float adaptiveQuality);
    static public List<float> GetAdaptiveSamples(TreeEditor.TreeGroup group, TreeEditor.TreeNode node, float adaptiveQuality);

    public TreeEditor.TreeGroupBranch[] branchGroups;
    public bool isInPreviewMode;
    public TreeEditor.TreeGroupLeaf[] leafGroups;
    public string materialHash;
    public Mesh mesh;
    public TreeEditor.TreeNode[] nodes;
    public Material optimizedCutoutMaterial;
    public Material optimizedSolidMaterial;
    public TreeEditor.TreeGroupRoot root;

    public TreeData();

    public TreeEditor.TreeGroup AddGroup(TreeEditor.TreeGroup parent, Type type);
    public TreeEditor.TreeNode AddNode(TreeEditor.TreeGroup g, TreeEditor.TreeNode parent);
    public TreeEditor.TreeNode AddNode(TreeEditor.TreeGroup g, TreeEditor.TreeNode parent, bool validate);
    public bool CheckExternalChanges();
    public void ClearReferences();
    public void DeleteGroup(TreeEditor.TreeGroup g);
    public void DeleteNode(TreeEditor.TreeNode n);
    public void DeleteNode(TreeEditor.TreeNode n, bool validate);
    public TreeEditor.TreeGroup DuplicateGroup(TreeEditor.TreeGroup g);
    public TreeEditor.TreeNode DuplicateNode(TreeEditor.TreeNode n);
    public TreeEditor.TreeGroup GetGroup(int id);
    public TreeEditor.TreeNode GetNode(int id);
    public void Initialize();
    public bool IsAncestor(TreeEditor.TreeGroup ancestor, TreeEditor.TreeGroup g);
    public void LockGroup(TreeEditor.TreeGroup g);
    public bool OptimizeMaterial(List<TreeEditor.TreeMaterial> materials, List<TreeEditor.TreeVertex> vertices, List<TreeEditor.TreeTriangle> triangles);
    public void PreviewMesh(Matrix4x4 worldToLocalMatrix, out Material outMaterials);
    public void SetGroupParent(TreeEditor.TreeGroup g, TreeEditor.TreeGroup parent);
    public void SetNodeParent(TreeEditor.TreeNode n, TreeEditor.TreeNode parent);
    public void UnlockGroup(TreeEditor.TreeGroup g);
    public void UpdateDistribution(int id);
    public void UpdateFrequency(int id);
    public void UpdateMesh(Matrix4x4 worldToLocalMatrix, out Material outMaterials);
    public void UpdateMesh(Matrix4x4 matrix, List<TreeEditor.TreeMaterial> materials, List<TreeEditor.TreeVertex> verts, List<TreeEditor.TreeTriangle> tris, List<TreeEditor.TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
    public void UpdateSeed(int id);
    public void ValidateReferences();

}

}
