using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class SupportedRenderingFeatures
{
    static public Experimental.Rendering.SupportedRenderingFeatures active { get; set; }

    public LightmapMixedBakeMode defaultMixedLightingMode { get; set; }
    public ReflectionProbeSupportFlags reflectionProbeSupportFlags { get; set; }
    public bool rendererOverridesEnvironmentLighting { get; set; }
    public bool rendererOverridesFog { get; set; }
    public bool rendererOverridesOtherLightingSettings { get; set; }
    public bool rendererSupportsLightProbeProxyVolumes { get; set; }
    public bool rendererSupportsMotionVectors { get; set; }
    public bool rendererSupportsReceiveShadows { get; set; }
    public bool rendererSupportsReflectionProbes { get; set; }
    public bool rendererSupportsRendererPriority { get; set; }
    public LightmapBakeType supportedLightmapBakeTypes { get; set; }
    public LightmapsMode supportedLightmapsModes { get; set; }
    public LightmapMixedBakeMode supportedMixedLightingModes { get; set; }

    public SupportedRenderingFeatures();

    public enum LightmapMixedBakeMode
    {
        None = 0,
        IndirectOnly = 1,
        Subtractive = 2,
        Shadowmask = 4,
    }

    public enum ReflectionProbeSupportFlags
    {
        None = 0,
        Rotation = 1,
    }

}

}
