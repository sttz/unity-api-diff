using System;
using System.Collections;
using System.Collections.Generic;
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
