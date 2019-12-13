using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class LightingSettings : Object
{
    public float albedoBoost { get; set; }
    public bool ao { get; set; }
    public float aoExponentDirect { get; set; }
    public float aoExponentIndirect { get; set; }
    public float aoMaxDistance { get; set; }
    public bool autoGenerate { get; set; }
    public bool bakedGI { get; set; }
    public int bounces { get; set; }
    public bool compressLightmaps { get; set; }
    public DenoiserType denoiserTypeAO { get; set; }
    public DenoiserType denoiserTypeDirect { get; set; }
    public DenoiserType denoiserTypeIndirect { get; set; }
    public LightmapsMode directionalityMode { get; set; }
    public int directSampleCount { get; set; }
    public int environmentSampleCount { get; set; }
    public bool exportTrainingData { get; set; }
    public bool extractAO { get; set; }
    public float filteringAtrousPositionSigmaAO { get; set; }
    public float filteringAtrousPositionSigmaDirect { get; set; }
    public float filteringAtrousPositionSigmaIndirect { get; set; }
    public int filteringGaussRadiusAO { get; set; }
    public int filteringGaussRadiusDirect { get; set; }
    public int filteringGaussRadiusIndirect { get; set; }
    public FilterMode filteringMode { get; set; }
    public FilterType filterTypeAO { get; set; }
    public FilterType filterTypeDirect { get; set; }
    public FilterType filterTypeIndirect { get; set; }
    public float indirectResolution { get; set; }
    public int indirectSampleCount { get; set; }
    public int lightmapMaxSize { get; set; }
    public int lightmapPadding { get; set; }
    public Lightmapper lightmapper { get; set; }
    public float lightmapResolution { get; set; }
    public float lightProbeSampleCountMultiplier { get; set; }
    public MixedLightingMode mixedBakeMode { get; set; }
    public bool prioritizeView { get; set; }
    public bool realtimeEnvironmentLighting { get; set; }
    public bool realtimeGI { get; set; }
    public Sampling sampling { get; set; }
    public string trainingDataDestination { get; set; }

    public LightingSettings();

    public enum Lightmapper
    {
        Enlighten = 0,
        ProgressiveCPU = 1,
        ProgressiveGPU = 2,
    }

    public enum Sampling
    {
        Auto = 0,
        Fixed = 1,
    }

    public enum FilterMode
    {
        None = 0,
        Auto = 1,
        Advanced = 2,
    }

    public enum DenoiserType
    {
        None = 0,
        Optix = 1,
        OpenImage = 2,
        RadeonPro = 3,
    }

    public enum FilterType
    {
        Gaussian = 0,
        ATrous = 1,
        None = 2,
    }

}

}
