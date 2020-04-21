using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public static class TerrainPaintUtility
{
    static public Experimental.TerrainAPI.PaintContext BeginPaintHeightmap(Terrain terrain, Rect boundsInTerrainSpace, int extraBorderPixels = 0);
    static public Experimental.TerrainAPI.PaintContext BeginPaintHoles(Terrain terrain, Rect boundsInTerrainSpace, int extraBorderPixels = 0);
    static public Experimental.TerrainAPI.PaintContext BeginPaintTexture(Terrain terrain, Rect boundsInTerrainSpace, TerrainLayer inputLayer, int extraBorderPixels = 0);
    static public void BuildTransformPaintContextUVToPaintContextUV(Experimental.TerrainAPI.PaintContext src, Experimental.TerrainAPI.PaintContext dst, out Vector4 scaleOffset);
    static public Experimental.TerrainAPI.BrushTransform CalculateBrushTransform(Terrain terrain, Vector2 brushCenterTerrainUV, float brushSize, float brushRotationDegrees);
    static public Experimental.TerrainAPI.PaintContext CollectNormals(Terrain terrain, Rect boundsInTerrainSpace, int extraBorderPixels = 0);
    static public void EndPaintHeightmap(Experimental.TerrainAPI.PaintContext ctx, string editorUndoName);
    static public void EndPaintHoles(Experimental.TerrainAPI.PaintContext ctx, string editorUndoName);
    static public void EndPaintTexture(Experimental.TerrainAPI.PaintContext ctx, string editorUndoName);
    static public int FindTerrainLayerIndex(Terrain terrain, TerrainLayer inputLayer);
    static public Material GetBlitMaterial();
    static public void GetBrushWorldSizeLimits(out float minBrushWorldSize, out float maxBrushWorldSize, float terrainTileWorldSize, int terrainTileTextureResolutionPixels, int minBrushResolutionPixels = 1, int maxBrushResolutionPixels = 8192);
    static public Material GetBuiltinPaintMaterial();
    static public Material GetCopyTerrainLayerMaterial();
    static public Material GetHeightBlitMaterial();
    static public Texture2D GetTerrainAlphaMapChecked(Terrain terrain, int mapIndex);
    static public void ReleaseContextResources(Experimental.TerrainAPI.PaintContext ctx);
    static public void SetupTerrainToolMaterialProperties(Experimental.TerrainAPI.PaintContext paintContext, Experimental.TerrainAPI.BrushTransform brushXform, Material material);

    public enum BuiltinPaintMaterialPasses
    {
        RaiseLowerHeight = 0,
        StampHeight = 1,
        SetHeights = 2,
        SmoothHeights = 3,
        PaintTexture = 4,
        PaintHoles = 5,
    }

}

}
