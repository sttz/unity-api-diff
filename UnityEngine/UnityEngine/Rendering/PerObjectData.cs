using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum PerObjectData
{
    None = 0,
    LightProbe = 1,
    ReflectionProbes = 2,
    LightProbeProxyVolume = 4,
    Lightmaps = 8,
    LightData = 16,
    MotionVectors = 32,
    LightIndices = 64,
    ReflectionProbeData = 128,
    OcclusionProbe = 256,
    OcclusionProbeProxyVolume = 512,
    ShadowMask = 1024,
}

}
