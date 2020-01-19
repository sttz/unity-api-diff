using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Light : Behaviour
{
    static public int pixelLightCount { get; set; }

    static public Light[] GetLights(LightType type, int layer);

    public bool alreadyLightmapped { get; set; }
    public Vector2 areaSize { get; set; }
    public bool attenuate { get; set; }
    public int bakedIndex { get; set; }
    public LightBakingOutput bakingOutput { get; set; }
    public float bounceIntensity { get; set; }
    public Color color { get; set; }
    public float colorTemperature { get; set; }
    public int commandBufferCount { get; }
    public Texture cookie { get; set; }
    public float cookieSize { get; set; }
    public int cullingMask { get; set; }
    public Flare flare { get; set; }
    public float intensity { get; set; }
    public bool isBaked { get; }
    public float[] layerShadowCullDistances { get; set; }
    public LightmapBakeType lightmapBakeType { get; set; }
    public LightmappingMode lightmappingMode { get; set; }
    public LightShadowCasterMode lightShadowCasterMode { get; set; }
    public float range { get; set; }
    public LightRenderMode renderMode { get; set; }
    public float shadowAngle { get; set; }
    public float shadowBias { get; set; }
    public float shadowConstantBias { get; set; }
    public int shadowCustomResolution { get; set; }
    public float shadowNearPlane { get; set; }
    public float shadowNormalBias { get; set; }
    public float shadowObjectSizeBias { get; set; }
    public float shadowRadius { get; set; }
    public Rendering.LightShadowResolution shadowResolution { get; set; }
    public LightShadows shadows { get; set; }
    public float shadowSoftness { get; set; }
    public float shadowSoftnessFade { get; set; }
    public float shadowStrength { get; set; }
    public float spotAngle { get; set; }
    public LightType type { get; set; }

    public Light();

    public void AddCommandBuffer(Rendering.LightEvent evt, Rendering.CommandBuffer buffer);
    public void AddCommandBuffer(Rendering.LightEvent evt, Rendering.CommandBuffer buffer, Rendering.ShadowMapPass shadowPassMask);
    public void AddCommandBufferAsync(Rendering.LightEvent evt, Rendering.CommandBuffer buffer, Rendering.ComputeQueueType queueType);
    public void AddCommandBufferAsync(Rendering.LightEvent evt, Rendering.CommandBuffer buffer, Rendering.ShadowMapPass shadowPassMask, Rendering.ComputeQueueType queueType);
    public Rendering.CommandBuffer[] GetCommandBuffers(Rendering.LightEvent evt);
    public void RemoveAllCommandBuffers();
    public void RemoveCommandBuffer(Rendering.LightEvent evt, Rendering.CommandBuffer buffer);
    public void RemoveCommandBuffers(Rendering.LightEvent evt);
    public void Reset();
    public void SetLightDirty();

}

}
