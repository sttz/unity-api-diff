using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class LightmapParameters : Object
{
    public int antiAliasingSamples { get; set; }
    public int AOAntiAliasingSamples { get; set; }
    public int AOQuality { get; set; }
    public float backFaceTolerance { get; set; }
    public int bakedLightmapTag { get; set; }
    public int blurRadius { get; set; }
    public float clusterResolution { get; set; }
    public int directLightQuality { get; set; }
    public float edgeStitching { get; set; }
    public int irradianceBudget { get; set; }
    public int irradianceQuality { get; set; }
    public bool isTransparent { get; set; }
    public bool limitLightmapCount { get; set; }
    public int maxLightmapCount { get; set; }
    public float modellingTolerance { get; set; }
    public float resolution { get; set; }
    public bool stitchEdges { get; set; }
    public int systemTag { get; set; }

    public LightmapParameters();

}

}
