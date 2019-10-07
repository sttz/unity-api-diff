using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public abstract class RenderPipelineAsset : ScriptableObject, Experimental.Rendering.IRenderPipelineAsset
{
    protected RenderPipelineAsset();

    protected System.Collections.Generic.IEnumerable<Experimental.Rendering.IRenderPipeline> CreatedInstances();
    public Experimental.Rendering.IRenderPipeline CreatePipeline();
    public void DestroyCreatedInstances();
    public Shader GetAutodeskInteractiveMaskedShader();
    public Shader GetAutodeskInteractiveShader();
    public Shader GetAutodeskInteractiveTransparentShader();
    public Material GetDefault2DMaterial();
    public Material GetDefaultLineMaterial();
    public Material GetDefaultMaterial();
    public Material GetDefaultParticleMaterial();
    public Shader GetDefaultShader();
    public Material GetDefaultTerrainMaterial();
    public Material GetDefaultUIETC1SupportedMaterial();
    public Material GetDefaultUIMaterial();
    public Material GetDefaultUIOverdrawMaterial();
    public string[] GetRenderingLayerMaskNames();
    public int GetTerrainBrushPassIndex();
    protected Experimental.Rendering.IRenderPipeline InternalCreatePipeline();
    protected void OnDisable();
    protected void OnValidate();

}

}
