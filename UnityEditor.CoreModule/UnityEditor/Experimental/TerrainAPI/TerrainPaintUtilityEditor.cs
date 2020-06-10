using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.TerrainAPI
{

public static class TerrainPaintUtilityEditor
{
    static public void DrawBrushPreview(Experimental.TerrainAPI.PaintContext heightmapPC, BrushPreview previewTexture, Texture brushTexture, Experimental.TerrainAPI.BrushTransform brushXform, Material proceduralMaterial, int materialPassIndex);
    static public Material GetDefaultBrushPreviewMaterial();
    static public void ShowDefaultPreviewBrush(Terrain terrain, Texture brushTexture, float brushSize);

    public enum BrushPreview
    {
        SourceRenderTexture = 0,
        DestinationRenderTexture = 1,
    }

}

}
