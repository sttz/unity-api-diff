using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class TerrainData : Object
{
    public int alphamapHeight { get; }
    public int alphamapLayers { get; }
    public int alphamapResolution { get; set; }
    public int alphamapTextureCount { get; }
    public Texture2D[] alphamapTextures { get; }
    public int alphamapWidth { get; }
    public int baseMapResolution { get; set; }
    public Bounds bounds { get; }
    public int detailHeight { get; }
    public int detailPatchCount { get; }
    public DetailPrototype[] detailPrototypes { get; set; }
    public int detailResolution { get; }
    public int detailResolutionPerPatch { get; }
    public int detailWidth { get; }
    public int heightmapHeight { get; }
    public int heightmapResolution { get; set; }
    public Vector3 heightmapScale { get; }
    public RenderTexture heightmapTexture { get; }
    public int heightmapWidth { get; }
    public Vector3 size { get; set; }
    public SplatPrototype[] splatPrototypes { get; set; }
    public TerrainLayer[] terrainLayers { get; set; }
    public float thickness { get; set; }
    public int treeInstanceCount { get; }
    public TreeInstance[] treeInstances { get; set; }
    public TreePrototype[] treePrototypes { get; set; }
    public float wavingGrassAmount { get; set; }
    public float wavingGrassSpeed { get; set; }
    public float wavingGrassStrength { get; set; }
    public Color wavingGrassTint { get; set; }

    public TerrainData();

    public float[0...,0...,0...] GetAlphamaps(int x, int y, int width, int height);
    public Texture2D GetAlphamapTexture(int index);
    public int[0...,0...] GetDetailLayer(int xBase, int yBase, int width, int height, int layer);
    public float GetHeight(int x, int y);
    public float[0...,0...] GetHeights(int xBase, int yBase, int width, int height);
    public float GetInterpolatedHeight(float x, float y);
    public Vector3 GetInterpolatedNormal(float x, float y);
    public float[] GetMaximumHeightError();
    public PatchExtents[] GetPatchMinMaxHeights();
    public float GetSteepness(float x, float y);
    public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight);
    public TreeInstance GetTreeInstance(int index);
    public void OverrideMaximumHeightError(float[] maxError);
    public void OverrideMinMaxPatchHeights(PatchExtents[] minMaxHeights);
    public void RefreshPrototypes();
    public void SetAlphamaps(int x, int y, float[0...,0...,0...] map);
    public void SetBaseMapDirty();
    public void SetDetailLayer(int xBase, int yBase, int layer, int[0...,0...] details);
    public void SetDetailResolution(int detailResolution, int resolutionPerPatch);
    public void SetHeights(int xBase, int yBase, float[0...,0...] heights);
    public void SetHeightsDelayLOD(int xBase, int yBase, float[0...,0...] heights);
    public void SetTreeInstance(int index, TreeInstance instance);
    public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately);

}

}