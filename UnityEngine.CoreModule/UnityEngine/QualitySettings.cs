using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class QualitySettings : Object
{
    static public ColorSpace activeColorSpace { get; }
    static public AnisotropicFiltering anisotropicFiltering { get; set; }
    static public int antiAliasing { get; set; }
    static public int asyncUploadBufferSize { get; set; }
    static public bool asyncUploadPersistentBuffer { get; set; }
    static public int asyncUploadTimeSlice { get; set; }
    static public bool billboardsFaceCameraPosition { get; set; }
    static public BlendWeights blendWeights { get; set; }
    static public QualityLevel currentLevel { get; set; }
    static public ColorSpace desiredColorSpace { get; }
    static public float lodBias { get; set; }
    static public int masterTextureLimit { get; set; }
    static public int maximumLODLevel { get; set; }
    static public int maxQueuedFrames { get; set; }
    static public string[] names { get; }
    static public int particleRaycastBudget { get; set; }
    static public int pixelLightCount { get; set; }
    static public bool realtimeReflectionProbes { get; set; }
    static public float resolutionScalingFixedDPIFactor { get; set; }
    static public float shadowCascade2Split { get; set; }
    static public Vector3 shadowCascade4Split { get; set; }
    static public int shadowCascades { get; set; }
    static public float shadowDistance { get; set; }
    static public ShadowmaskMode shadowmaskMode { get; set; }
    static public float shadowNearPlaneOffset { get; set; }
    static public ShadowProjection shadowProjection { get; set; }
    static public ShadowResolution shadowResolution { get; set; }
    static public ShadowQuality shadows { get; set; }
    static public bool softParticles { get; set; }
    static public bool softVegetation { get; set; }
    static public bool streamingMipmapsActive { get; set; }
    static public bool streamingMipmapsAddAllCameras { get; set; }
    static public int streamingMipmapsMaxFileIORequests { get; set; }
    static public int streamingMipmapsMaxLevelReduction { get; set; }
    static public float streamingMipmapsMemoryBudget { get; set; }
    static public int streamingMipmapsRenderersPerFrame { get; set; }
    static public int vSyncCount { get; set; }

    static public void DecreaseLevel();
    static public void DecreaseLevel(bool applyExpensiveChanges);
    static public int GetQualityLevel();
    static public void IncreaseLevel();
    static public void IncreaseLevel(bool applyExpensiveChanges);
    static public void SetQualityLevel(int index);
    static public void SetQualityLevel(int index, bool applyExpensiveChanges);

}

}
