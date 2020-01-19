using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct ScriptableRenderContext
{
    static public void BeginRenderPassInternal(IntPtr _self, int w, int h, int samples, Experimental.Rendering.RenderPassAttachment[] colors, Experimental.Rendering.RenderPassAttachment depth);
    static public void BeginSubPassInternal(IntPtr _self, Experimental.Rendering.RenderPassAttachment[] colors, Experimental.Rendering.RenderPassAttachment[] inputs, bool readOnlyDepth);
    static public void EmitWorldGeometryForSceneView(Camera cullingCamera);
    static public void EndRenderPassInternal(IntPtr _self);

    public void DrawRenderers(Experimental.Rendering.FilterResults renderers, Experimental.Rendering.DrawRendererSettings drawSettings, Experimental.Rendering.FilterRenderersSettings filterSettings);
    public void DrawRenderers(Experimental.Rendering.FilterResults renderers, Experimental.Rendering.DrawRendererSettings drawSettings, Experimental.Rendering.FilterRenderersSettings filterSettings, Experimental.Rendering.RenderStateBlock stateBlock);
    public void DrawRenderers(Experimental.Rendering.FilterResults renderers, Experimental.Rendering.DrawRendererSettings drawSettings, Experimental.Rendering.FilterRenderersSettings filterSettings, List<Experimental.Rendering.RenderStateMapping> stateMap);
    public void DrawShadows(Experimental.Rendering.DrawShadowsSettings settings);
    public void DrawSkybox(Camera camera);
    public void ExecuteCommandBuffer(Rendering.CommandBuffer commandBuffer);
    public void ExecuteCommandBufferAsync(Rendering.CommandBuffer commandBuffer, Rendering.ComputeQueueType queueType);
    public void SetupCameraProperties(Camera camera);
    public void SetupCameraProperties(Camera camera, bool stereoSetup);
    public void StartMultiEye(Camera camera);
    public void StereoEndRender(Camera camera);
    public void StopMultiEye(Camera camera);
    public void Submit();

}

}
