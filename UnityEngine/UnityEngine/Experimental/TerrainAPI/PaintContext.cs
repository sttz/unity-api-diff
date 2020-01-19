using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public class PaintContext
{
    static public void ApplyDelayedActions();
    static public Experimental.TerrainAPI.PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, int extraBorderPixels = 0);

    public RenderTexture destinationRenderTexture { get; private set; }
    public RenderTexture oldRenderTexture { get; private set; }
    public Terrain originTerrain { get; }
    public RectInt pixelRect { get; }
    public Vector2 pixelSize { get; }
    public RenderTexture sourceRenderTexture { get; private set; }
    public int targetTextureHeight { get; }
    public int targetTextureWidth { get; }
    public int terrainCount { get; }

    public PaintContext(Terrain terrain, RectInt pixelRect, int targetTextureWidth, int targetTextureHeight);

    public void Cleanup(bool restoreRenderTexture = true);
    public void CreateRenderTargets(RenderTextureFormat colorFormat);
    public void GatherAlphamap(TerrainLayer inputLayer, bool addLayerIfDoesntExist = true);
    public void GatherHeightmap();
    public void GatherNormals();
    public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex);
    public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex);
    public Terrain GetTerrain(int terrainIndex);
    public void ScatterAlphamap(string editorUndoName);
    public void ScatterHeightmap(string editorUndoName);

}

}
