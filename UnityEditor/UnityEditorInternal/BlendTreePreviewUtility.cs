using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class BlendTreePreviewUtility
{
    static public void CalculateBlendTexture(Animator animator, int layerIndex, int stateHash, Texture2D blendTexture, Texture2D[] weightTextures, Rect rect);
    static protected void CalculateBlendTexture(Animator animator, int layerIndex, int stateHash, Texture2D blendTexture, Texture2D[] weightTextures, float minX, float minY, float maxX, float maxY);
    static public void CalculateRootBlendTreeChildWeights(Animator animator, int layerIndex, int stateHash, out float[] weightArray, float blendX, float blendY);
    static public void GetRootBlendTreeChildWeights(Animator animator, int layerIndex, int stateHash, out float[] weightArray);

    public BlendTreePreviewUtility();

}

}
