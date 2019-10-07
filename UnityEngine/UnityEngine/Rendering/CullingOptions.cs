using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum CullingOptions
{
    None = 0,
    ForceEvenIfCameraIsNotActive = 1,
    OcclusionCull = 2,
    NeedsLighting = 4,
    NeedsReflectionProbes = 8,
    Stereo = 16,
    DisablePerObjectCulling = 32,
    ShadowCasters = 64,
}

}
