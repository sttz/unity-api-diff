using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public enum RendererConfiguration
{
    None = 0,
    PerObjectLightProbe = 1,
    PerObjectReflectionProbes = 2,
    PerObjectLightProbeProxyVolume = 4,
    PerObjectLightmaps = 8,
    ProvideLightIndices = 16,
    PerObjectMotionVectors = 32,
    PerObjectLightIndices8 = 64,
    ProvideReflectionProbeIndices = 128,
    PerObjectOcclusionProbe = 256,
    PerObjectOcclusionProbeProxyVolume = 512,
    PerObjectShadowMask = 1024,
}

}
