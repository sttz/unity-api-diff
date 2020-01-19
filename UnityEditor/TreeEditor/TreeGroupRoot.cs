using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeGroupRoot : TreeEditor.TreeGroup
{
    public float adaptiveLODQuality;
    public float aoDensity;
    public bool enableAmbientOcclusion;
    public bool enableMaterialOptimize;
    public bool enableWelding;
    public float groundOffset;
    public Matrix4x4 rootMatrix;
    public float rootSpread;
    public int shadowTextureQuality;

    public TreeGroupRoot();

    public bool CanHaveSubGroups();
    public void SetRootMatrix(Matrix4x4 m);
    public void UpdateParameters();

}

}
