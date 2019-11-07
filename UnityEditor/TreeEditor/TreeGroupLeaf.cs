using System;
using UnityEngine;

namespace TreeEditor
{

public class TreeGroupLeaf : TreeEditor.TreeGroup
{
    public int geometryMode;
    public float horizontalAlign;
    public GameObject instanceMesh;
    public Material materialLeaf;
    public float perpendicularAlign;
    public Vector2 size;

    public TreeGroupLeaf();

    public void BuildAOSpheres(System.Collections.Generic.List<TreeEditor.TreeAOSphere> aoSpheres);
    public bool CanHaveSubGroups();
    public void UpdateMatrix();
    public void UpdateMesh(System.Collections.Generic.List<TreeEditor.TreeMaterial> materials, System.Collections.Generic.List<TreeEditor.TreeVertex> verts, System.Collections.Generic.List<TreeEditor.TreeTriangle> tris, System.Collections.Generic.List<TreeEditor.TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
    public void UpdateParameters();

    public enum GeometryMode
    {
        PLANE = 0,
        CROSS = 1,
        TRI_CROSS = 2,
        BILLBOARD = 3,
        MESH = 4,
    }

}

}
