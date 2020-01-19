using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class LightmapEditorSettings
{
    static public float aoAmount { get; set; }
    static public float aoContrast { get; set; }
    static public float aoExponentDirect { get; set; }
    static public float aoExponentIndirect { get; set; }
    static public float aoMaxDistance { get; set; }
    static public float bakeResolution { get; set; }
    static public float bounceBoost { get; set; }
    static public float bounceIntensity { get; set; }
    static public int bounces { get; set; }
    static public DenoiserType denoiserTypeAO { get; set; }
    static public DenoiserType denoiserTypeDirect { get; set; }
    static public DenoiserType denoiserTypeIndirect { get; set; }
    static public int directSampleCount { get; set; }
    static public bool enableAmbientOcclusion { get; set; }
    static public bool exportTrainingData { get; set; }
    static public float filteringAtrousPositionSigmaAO { get; set; }
    static public float filteringAtrousPositionSigmaDirect { get; set; }
    static public float filteringAtrousPositionSigmaIndirect { get; set; }
    static public int filteringGaussRadiusAO { get; set; }
    static public int filteringGaussRadiusDirect { get; set; }
    static public int filteringGaussRadiusIndirect { get; set; }
    static public FilterMode filteringMode { get; set; }
    static public FilterType filterTypeAO { get; set; }
    static public FilterType filterTypeDirect { get; set; }
    static public FilterType filterTypeIndirect { get; set; }
    static public float finalGatherContrastThreshold { get; set; }
    static public float finalGatherGradientThreshold { get; set; }
    static public int finalGatherInterpolationPoints { get; set; }
    static public int finalGatherRays { get; set; }
    static public GIBakeBackend giBakeBackend { get; set; }
    static public PathTracerFilter giPathTracerFilter { get; set; }
    static public PathTracerSampling giPathTracerSampling { get; set; }
    static public int indirectSampleCount { get; set; }
    static public float lastUsedResolution { get; set; }
    static public Lightmapper lightmapper { get; set; }
    static public LightmapsMode lightmapsMode { get; set; }
    static public bool lockAtlas { get; set; }
    static public int maxAtlasHeight { get; set; }
    static public int maxAtlasSize { get; set; }
    static public int maxAtlasWidth { get; set; }
    static public MixedLightingMode mixedBakeMode { get; set; }
    static public int padding { get; set; }
    static public bool prioritizeView { get; set; }
    static public UnityEditor.LightmapBakeQuality quality { get; set; }
    static public float realtimeResolution { get; set; }
    static public Rendering.ReflectionCubemapCompression reflectionCubemapCompression { get; set; }
    static public float resolution { get; set; }
    static public Sampling sampling { get; set; }
    static public Color skyLightColor { get; set; }
    static public float skyLightIntensity { get; set; }
    static public bool textureCompression { get; set; }
    static public string trainingDataDestination { get; set; }

    public enum DenoiserType
    {
        None = 0,
        Optix = 1,
        OpenImage = 2,
    }

    public enum FilterMode
    {
        None = 0,
        Auto = 1,
        Advanced = 2,
    }

    public enum FilterType
    {
        Gaussian = 0,
        ATrous = 1,
        None = 2,
    }

    public enum GIBakeBackend
    {
        Radiosity = 0,
        PathTracer = 1,
    }

    public enum Lightmapper
    {
        Radiosity = 0,
        Enlighten = 0,
        PathTracer = 1,
        ProgressiveCPU = 1,
        ProgressiveGPU = 2,
    }

    public enum PathTracerFilter
    {
        Gaussian = 0,
        ATrous = 1,
    }

    public enum PathTracerSampling
    {
        Auto = 0,
        Fixed = 1,
    }

    public enum Sampling
    {
        Auto = 0,
        Fixed = 1,
    }

}

}
