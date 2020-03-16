using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class FBXMaterialDescriptionPreprocessor : UnityEditor.AssetPostprocessor
{
    public FBXMaterialDescriptionPreprocessor();

    public int GetPostprocessOrder();
    public uint GetVersion();
    public void OnPreprocessMaterialDescription(UnityEditor.AssetImporters.MaterialDescription description, Material material, AnimationClip[] clips);

}

}