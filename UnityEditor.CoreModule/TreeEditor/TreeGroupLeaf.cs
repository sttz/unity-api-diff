using System;
using System.Collections;
using System.Collections.Generic;
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

    public void BuildAOSpheres(List<TreeEditor.TreeAOSphere> aoSpheres);
    public bool CanHaveSubGroups();
    public void UpdateMatrix();
    public void UpdateMesh(List<TreeEditor.TreeMaterial> materials, List<TreeEditor.TreeVertex> verts, List<TreeEditor.TreeTriangle> tris, List<TreeEditor.TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
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
