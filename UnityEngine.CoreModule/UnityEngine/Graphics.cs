using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Graphics
{
    static public RenderBuffer activeColorBuffer { get; }
    static public ColorGamut activeColorGamut { get; }
    static public RenderBuffer activeDepthBuffer { get; }
    static public Rendering.GraphicsTier activeTier { get; set; }
    static public string deviceName { get; }
    static public string deviceVendor { get; }
    static public string deviceVersion { get; }

    static public void Blit(Texture source, RenderTexture dest);
    static public void Blit(Texture source, Material mat);
    static public void Blit(Texture source, RenderTexture dest, Material mat);
    static public void Blit(Texture source, Material mat, int pass);
    static public void Blit(Texture source, RenderTexture dest, Material mat, int pass);
    static public void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset);
    static public void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets);
    static public void ClearRandomWriteTargets();
    static public bool ConvertTexture(Texture src, Texture dst);
    static public bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement);
    static public void CopyTexture(Texture src, Texture dst);
    static public void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement);
    static public void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip);
    static public void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY);
    static public Rendering.GPUFence CreateGPUFence();
    static public Rendering.GPUFence CreateGPUFence(Rendering.SynchronisationStage stage);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, int materialIndex);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, Rendering.LightProbeUsage lightProbeUsage);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes);
    static public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume);
    static public void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume);
    static public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage);
    static public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume);
    static public void DrawMeshNow(Mesh mesh, Matrix4x4 matrix);
    static public void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex);
    static public void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation);
    static public void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex);
    static public void DrawProcedural(MeshTopology topology, int vertexCount);
    static public void DrawProcedural(MeshTopology topology, int vertexCount, int instanceCount);
    static public void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs);
    static public void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset);
    static public void DrawTexture(Rect screenRect, Texture texture);
    static public void DrawTexture(Rect screenRect, Texture texture, Material mat);
    static public void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass);
    static public void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder);
    static public void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder);
    static public void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass);
    static public void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass);
    static public void ExecuteCommandBuffer(Rendering.CommandBuffer buffer);
    static public void ExecuteCommandBufferAsync(Rendering.CommandBuffer buffer, Rendering.ComputeQueueType queueType);
    static public void SetRandomWriteTarget(int index, ComputeBuffer uav);
    static public void SetRandomWriteTarget(int index, RenderTexture uav);
    static public void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue);
    static public void SetRenderTarget(RenderTexture rt);
    static public void SetRenderTarget(RenderTargetSetup setup);
    static public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer);
    static public void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer);
    static public void SetRenderTarget(RenderTexture rt, int mipLevel);
    static public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel);
    static public void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face);
    static public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face);
    static public void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice);
    static public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice);
    static public void WaitOnGPUFence(Rendering.GPUFence fence);
    static public void WaitOnGPUFence(Rendering.GPUFence fence, Rendering.SynchronisationStage stage);

    public Graphics();

}

}