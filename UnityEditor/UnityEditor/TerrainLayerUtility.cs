using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class TerrainLayerUtility
{
    static public bool CheckNormalMapTextureType(Texture2D texture);
    static public int ShowTerrainLayersSelectionHelper(Terrain terrain, int activeTerrainLayer);
    static public void TilingSettingsUI(TerrainLayer terrainLayer);
    static public void TilingSettingsUI(UnityEditor.SerializedProperty tileSize, UnityEditor.SerializedProperty tileOffset);
    static public void ValidateDiffuseTextureUI(Texture2D texture);
    static public void ValidateMaskMapTextureUI(Texture2D texture);
    static public void ValidateNormalMapTextureUI(Texture2D texture, bool normalMapTextureType);

}

}
