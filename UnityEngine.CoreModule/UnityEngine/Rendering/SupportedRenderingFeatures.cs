using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public class SupportedRenderingFeatures
{
    static public Rendering.SupportedRenderingFeatures active { get; set; }

    public LightmapMixedBakeModes defaultMixedLightingModes { get; set; }
    public bool editableMaterialRenderQueue { get; set; }
    public bool enlighten { get; set; }
    public LightmapBakeType lightmapBakeTypes { get; set; }
    public LightmapsMode lightmapsModes { get; set; }
    public bool lightProbeProxyVolumes { get; set; }
    public LightmapMixedBakeModes mixedLightingModes { get; set; }
    public bool motionVectors { get; set; }
    public bool overridesEnvironmentLighting { get; set; }
    public bool overridesFog { get; set; }
    public bool overridesLODBias { get; set; }
    public bool overridesMaximumLODLevel { get; set; }
    public bool overridesOtherLightingSettings { get; set; }
    public bool overridesRealtimeReflectionProbes { get; set; }
    public bool overridesShadowmask { get; set; }
    public bool particleSystemInstancing { get; set; }
    public bool receiveShadows { get; set; }
    public ReflectionProbeModes reflectionProbeModes { get; set; }
    public bool reflectionProbes { get; set; }
    public bool rendererPriority { get; set; }
    public bool rendererProbes { get; set; }
    public bool rendersUIOverlay { get; set; }
    public bool terrainDetailUnsupported { get; set; }

    public SupportedRenderingFeatures();

    public enum LightmapMixedBakeModes
    {
        None = 0,
        IndirectOnly = 1,
        Subtractive = 2,
        Shadowmask = 4,
    }

    public enum ReflectionProbeModes
    {
        None = 0,
        Rotation = 1,
    }

}

}
