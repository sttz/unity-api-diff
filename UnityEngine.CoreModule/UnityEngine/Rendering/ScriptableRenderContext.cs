using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ScriptableRenderContext : IEquatable<Rendering.ScriptableRenderContext>
{
    static public void EmitWorldGeometryForSceneView(Camera cullingCamera);

    public void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex = -1);
    public Rendering.ScopedRenderPass BeginScopedRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex = -1);
    public Rendering.ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly = false);
    public Rendering.ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly = false);
    public void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly = false);
    public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly = false);
    public Rendering.CullingResults Cull(Rendering.ScriptableCullingParameters parameters);
    public void DrawGizmos(Camera camera, Rendering.GizmoSubset gizmoSubset);
    public void DrawRenderers(Rendering.CullingResults cullingResults, Rendering.DrawingSettings drawingSettings, Rendering.FilteringSettings filteringSettings);
    public void DrawRenderers(Rendering.CullingResults cullingResults, Rendering.DrawingSettings drawingSettings, Rendering.FilteringSettings filteringSettings, Rendering.RenderStateBlock stateBlock);
    public void DrawRenderers(Rendering.CullingResults cullingResults, Rendering.DrawingSettings drawingSettings, Rendering.FilteringSettings filteringSettings, Unity.Collections.NativeArray<Rendering.ShaderTagId> renderTypes, Unity.Collections.NativeArray<Rendering.RenderStateBlock> stateBlocks);
    public void DrawShadows(Rendering.ShadowDrawingSettings settings);
    public void DrawSkybox(Camera camera);
    public void EndRenderPass();
    public void EndSubPass();
    public bool Equals(object obj);
    public bool Equals(Rendering.ScriptableRenderContext other);
    public void ExecuteCommandBuffer(Rendering.CommandBuffer commandBuffer);
    public void ExecuteCommandBufferAsync(Rendering.CommandBuffer commandBuffer, Rendering.ComputeQueueType queueType);
    public int GetHashCode();
    public void SetupCameraProperties(Camera camera, bool stereoSetup = false);
    public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye);
    public void StartMultiEye(Camera camera);
    public void StartMultiEye(Camera camera, int eye);
    public void StereoEndRender(Camera camera);
    public void StereoEndRender(Camera camera, int eye);
    public void StereoEndRender(Camera camera, int eye, bool isFinalPass);
    public void StopMultiEye(Camera camera);
    public void Submit();

}

}
