using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Terrain : Behaviour
{
    static public Terrain activeTerrain { get; }
    static public Terrain[] activeTerrains { get; }
    static public Experimental.Rendering.GraphicsFormat heightmapFormat { get; }
    static public RenderTextureFormat heightmapRenderTextureFormat { get; }
    static public TextureFormat heightmapTextureFormat { get; }
    static public Experimental.Rendering.GraphicsFormat normalmapFormat { get; }
    static public RenderTextureFormat normalmapRenderTextureFormat { get; }
    static public TextureFormat normalmapTextureFormat { get; }

    static public GameObject CreateTerrainGameObject(TerrainData assignTerrain);
    static public void SetConnectivityDirty();

    public bool allowAutoConnect { get; set; }
    public bool bakeLightProbesForTrees { get; set; }
    public float basemapDistance { get; set; }
    public Terrain bottomNeighbor { get; }
    public bool castShadows { get; set; }
    public bool collectDetailPatches { get; set; }
    public bool deringLightProbesForTrees { get; set; }
    public float detailObjectDensity { get; set; }
    public float detailObjectDistance { get; set; }
    public bool drawHeightmap { get; set; }
    public bool drawInstanced { get; set; }
    public bool drawTreesAndFoliage { get; set; }
    public TerrainRenderFlags editorRenderFlags { get; set; }
    public bool freeUnusedRenderingResources { get; set; }
    public int groupingID { get; set; }
    public int heightmapMaximumLOD { get; set; }
    public float heightmapPixelError { get; set; }
    public Terrain leftNeighbor { get; }
    public float legacyShininess { get; set; }
    public Color legacySpecular { get; set; }
    public int lightmapIndex { get; set; }
    public Vector4 lightmapScaleOffset { get; set; }
    public Material materialTemplate { get; set; }
    public MaterialType materialType { get; set; }
    public RenderTexture normalmapTexture { get; }
    public Vector3 patchBoundsMultiplier { get; set; }
    public bool preserveTreePrototypeLayers { get; set; }
    public int realtimeLightmapIndex { get; set; }
    public Vector4 realtimeLightmapScaleOffset { get; set; }
    public Rendering.ReflectionProbeUsage reflectionProbeUsage { get; set; }
    public Terrain rightNeighbor { get; }
    public Rendering.ShadowCastingMode shadowCastingMode { get; set; }
    public float splatmapDistance { get; set; }
    public TerrainData terrainData { get; set; }
    public Terrain topNeighbor { get; }
    public float treeBillboardDistance { get; set; }
    public float treeCrossFadeLength { get; set; }
    public float treeDistance { get; set; }
    public float treeLODBiasMultiplier { get; set; }
    public int treeMaximumFullLODCount { get; set; }

    public Terrain();

    public void AddTreeInstance(TreeInstance instance);
    public void ApplyDelayedHeightmapModification();
    public void Flush();
    public void GetClosestReflectionProbes(System.Collections.Generic.List<Rendering.ReflectionProbeBlendInfo> result);
    public Vector3 GetPosition();
    public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest);
    public float SampleHeight(Vector3 worldPosition);
    public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);
    public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties);

    public enum MaterialType
    {
        BuiltInStandard = 0,
        BuiltInLegacyDiffuse = 1,
        BuiltInLegacySpecular = 2,
        Custom = 3,
    }

}

}
