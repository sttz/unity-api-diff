using System;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class ThreeDSMaterialDescriptionPreprocessor : UnityEditor.AssetPostprocessor
{
    public ThreeDSMaterialDescriptionPreprocessor();

    public int GetPostprocessOrder();
    public uint GetVersion();
    public void OnPreprocessMaterialDescription(UnityEditor.AssetImporters.MaterialDescription description, Material material, AnimationClip[] clips);

}

}
