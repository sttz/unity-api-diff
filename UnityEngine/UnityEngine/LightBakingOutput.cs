using System;
using UnityEngine;

namespace UnityEngine
{

public struct LightBakingOutput
{
    public bool isBaked;
    public LightmapBakeType lightmapBakeType;
    public MixedLightingMode mixedLightingMode;
    public int occlusionMaskChannel;
    public int probeOcclusionLightIndex;

}

}
