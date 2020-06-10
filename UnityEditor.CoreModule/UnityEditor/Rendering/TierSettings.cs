using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{

public struct TierSettings
{
    public bool cascadedShadowMaps;
    public bool detailNormalMap;
    public bool enableLPPV;
    public bool hdr;
    public Rendering.CameraHDRMode hdrMode;
    public bool prefer32BitShadowMaps;
    public Rendering.RealtimeGICPUUsage realtimeGICPUUsage;
    public bool reflectionProbeBlending;
    public bool reflectionProbeBoxProjection;
    public RenderingPath renderingPath;
    public bool semitransparentShadows;
    public UnityEditor.Rendering.ShaderQuality standardShaderQuality;

}

}
