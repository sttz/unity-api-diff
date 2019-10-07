using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public abstract class RenderPipelineAsset : ScriptableObject
{
    public Shader autodeskInteractiveMaskedShader { get; }
    public Shader autodeskInteractiveShader { get; }
    public Shader autodeskInteractiveTransparentShader { get; }
    public Material default2DMaterial { get; }
    public Material defaultLineMaterial { get; }
    public Material defaultMaterial { get; }
    public Material defaultParticleMaterial { get; }
    public Shader defaultShader { get; }
    public Shader defaultSpeedTree7Shader { get; }
    public Shader defaultSpeedTree8Shader { get; }
    public Material defaultTerrainMaterial { get; }
    public Material defaultUIETC1SupportedMaterial { get; }
    public Material defaultUIMaterial { get; }
    public Material defaultUIOverdrawMaterial { get; }
    public string[] renderingLayerMaskNames { get; }
    public int terrainBrushPassIndex { get; }
    public Shader terrainDetailGrassBillboardShader { get; }
    public Shader terrainDetailGrassShader { get; }
    public Shader terrainDetailLitShader { get; }

    protected RenderPipelineAsset();

    protected Rendering.RenderPipeline CreatePipeline();
    protected void OnDisable();
    protected void OnValidate();

}

}
