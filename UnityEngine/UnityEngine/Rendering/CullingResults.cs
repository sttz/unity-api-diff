using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct CullingResults : IEquatable<Rendering.CullingResults>
{
    public int lightAndReflectionProbeIndexCount { get; }
    public int lightIndexCount { get; }
    public int reflectionProbeIndexCount { get; }
    public Unity.Collections.NativeArray<Rendering.VisibleLight> visibleLights { get; }
    public Unity.Collections.NativeArray<Rendering.VisibleLight> visibleOffscreenVertexLights { get; }
    public Unity.Collections.NativeArray<Rendering.VisibleReflectionProbe> visibleReflectionProbes { get; }

    public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Rendering.ShadowSplitData shadowSplitData);
    public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Rendering.ShadowSplitData shadowSplitData);
    public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out Rendering.ShadowSplitData shadowSplitData);
    public bool Equals(Rendering.CullingResults other);
    public bool Equals(object obj);
    public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer);
    public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer);
    public int GetHashCode();
    public Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator);
    public Unity.Collections.NativeArray<int> GetReflectionProbeIndexMap(Unity.Collections.Allocator allocator);
    public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds);
    public void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);
    public void SetReflectionProbeIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);

}

}
