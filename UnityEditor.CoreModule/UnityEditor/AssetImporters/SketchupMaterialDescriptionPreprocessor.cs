using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public class SketchupMaterialDescriptionPreprocessor : UnityEditor.AssetPostprocessor
{
    public SketchupMaterialDescriptionPreprocessor();

    public int GetPostprocessOrder();
    public uint GetVersion();
    public void OnPreprocessMaterialDescription(UnityEditor.AssetImporters.MaterialDescription description, Material material, AnimationClip[] clips);

}

}
