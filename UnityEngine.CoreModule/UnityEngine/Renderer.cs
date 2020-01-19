using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class Renderer : Component
{
    public bool allowOcclusionWhenDynamic { get; set; }
    public Bounds bounds { get; }
    public bool castShadows { get; set; }
    public bool enabled { get; set; }
    public bool forceRenderingOff { get; set; }
    public bool isPartOfStaticBatch { get; }
    public bool isVisible { get; }
    public int lightmapIndex { get; set; }
    public Vector4 lightmapScaleOffset { get; set; }
    public Vector4 lightmapTilingOffset { get; set; }
    public Transform lightProbeAnchor { get; set; }
    public GameObject lightProbeProxyVolumeOverride { get; set; }
    public Rendering.LightProbeUsage lightProbeUsage { get; set; }
    public Matrix4x4 localToWorldMatrix { get; }
    public Material material { get; set; }
    public Material[] materials { get; set; }
    public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
    public bool motionVectors { get; set; }
    public Transform probeAnchor { get; set; }
    public Experimental.Rendering.RayTracingMode rayTracingMode { get; set; }
    public int realtimeLightmapIndex { get; set; }
    public Vector4 realtimeLightmapScaleOffset { get; set; }
    public bool receiveShadows { get; set; }
    public Rendering.ReflectionProbeUsage reflectionProbeUsage { get; set; }
    public int rendererPriority { get; set; }
    public uint renderingLayerMask { get; set; }
    public Rendering.ShadowCastingMode shadowCastingMode { get; set; }
    public Material sharedMaterial { get; set; }
    public Material[] sharedMaterials { get; set; }
    public int sortingLayerID { get; set; }
    public string sortingLayerName { get; set; }
    public int sortingOrder { get; set; }
    public bool useLightProbes { get; set; }
    public Matrix4x4 worldToLocalMatrix { get; }

    public Renderer();

    public void GetClosestReflectionProbes(List<Rendering.ReflectionProbeBlendInfo> result);
    public void GetMaterials(List<Material> m);
    public void GetPropertyBlock(MaterialPropertyBlock properties);
    public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);
    public void GetSharedMaterials(List<Material> m);
    public bool HasPropertyBlock();
    public void SetPropertyBlock(MaterialPropertyBlock properties);
    public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);

}

}
