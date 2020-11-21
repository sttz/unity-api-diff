using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.TerrainAPI
{

public class PaintContext
{
    static public float kNormalizedHeightScale { get; }

    static public void ApplyDelayedActions();
    static public Experimental.TerrainAPI.PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, int extraBorderPixels = 0, bool texelPadding = true);

    public RenderTexture destinationRenderTexture { get; private set; }
    public float heightWorldSpaceMin { get; }
    public float heightWorldSpaceSize { get; }
    public RenderTexture oldRenderTexture { get; private set; }
    public Terrain originTerrain { get; }
    public RectInt pixelRect { get; }
    public Vector2 pixelSize { get; }
    public RenderTexture sourceRenderTexture { get; private set; }
    public int targetTextureHeight { get; }
    public int targetTextureWidth { get; }
    public int terrainCount { get; }

    public PaintContext(Terrain terrain, RectInt pixelRect, int targetTextureWidth, int targetTextureHeight, bool texelPadding = true);

    public void Cleanup(bool restoreRenderTexture = true);
    public void CreateRenderTargets(RenderTextureFormat colorFormat);
    public void Gather(Func<ITerrainInfo, Texture> terrainSource, Color defaultColor, Material blitMaterial = null, int blitPass = 0, Action<ITerrainInfo> beforeBlit = null, Action<ITerrainInfo> afterBlit = null);
    public void GatherAlphamap(TerrainLayer inputLayer, bool addLayerIfDoesntExist = true);
    public void GatherHeightmap();
    public void GatherHoles();
    public void GatherNormals();
    public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex);
    public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex);
    public Terrain GetTerrain(int terrainIndex);
    public void Scatter(Func<ITerrainInfo, RenderTexture> terrainDest, Material blitMaterial = null, int blitPass = 0, Action<ITerrainInfo> beforeBlit = null, Action<ITerrainInfo> afterBlit = null);
    public void ScatterAlphamap(string editorUndoName);
    public void ScatterHeightmap(string editorUndoName);
    public void ScatterHoles(string editorUndoName);

    public interface ITerrainInfo
    {
        public RectInt clippedPCPixels { get; }
        public RectInt clippedTerrainPixels { get; }
        public bool gatherEnable { get; set; }
        public bool scatterEnable { get; set; }
        public Terrain terrain { get; }
        public object userData { get; set; }

    }

}

}
