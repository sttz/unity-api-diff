using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct CullResults
{
    static public Experimental.Rendering.CullResults Cull(Experimental.Rendering.ScriptableCullingParameters parameters, Experimental.Rendering.ScriptableRenderContext renderLoop);
    static public void Cull(Experimental.Rendering.ScriptableCullingParameters parameters, Experimental.Rendering.ScriptableRenderContext renderLoop, Experimental.Rendering.CullResults results);
    static public bool Cull(Camera camera, Experimental.Rendering.ScriptableRenderContext renderLoop, out Experimental.Rendering.CullResults results);
    static public bool GetCullingParameters(Camera camera, out Experimental.Rendering.ScriptableCullingParameters cullingParameters);
    static public bool GetCullingParameters(Camera camera, bool stereoAware, out Experimental.Rendering.ScriptableCullingParameters cullingParameters);

    public System.Collections.Generic.List<Experimental.Rendering.VisibleLight> visibleLights;
    public System.Collections.Generic.List<Experimental.Rendering.VisibleLight> visibleOffscreenVertexLights;
    public System.Collections.Generic.List<Experimental.Rendering.VisibleReflectionProbe> visibleReflectionProbes;
    public Experimental.Rendering.FilterResults visibleRenderers;

    public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Experimental.Rendering.ShadowSplitData shadowSplitData);
    public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Experimental.Rendering.ShadowSplitData shadowSplitData);
    public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Experimental.Rendering.ShadowSplitData shadowSplitData);
    public void FillLightIndices(ComputeBuffer computeBuffer);
    public int[] GetLightIndexMap();
    public int GetLightIndicesCount();
    public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds);
    public void SetLightIndexMap(int[] mapping);

}

}
