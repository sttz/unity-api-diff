using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LightProbeProxyVolume : Behaviour
{
    static public bool isFeatureSupported { get; }

    public BoundingBoxMode boundingBoxMode { get; set; }
    public Bounds boundsGlobal { get; }
    public DataFormat dataFormat { get; set; }
    public int gridResolutionX { get; set; }
    public int gridResolutionY { get; set; }
    public int gridResolutionZ { get; set; }
    public Vector3 originCustom { get; set; }
    public float probeDensity { get; set; }
    public ProbePositionMode probePositionMode { get; set; }
    public QualityMode qualityMode { get; set; }
    public RefreshMode refreshMode { get; set; }
    public ResolutionMode resolutionMode { get; set; }
    public Vector3 sizeCustom { get; set; }

    public LightProbeProxyVolume();

    public void Update();

    public enum BoundingBoxMode
    {
        AutomaticLocal = 0,
        AutomaticWorld = 1,
        Custom = 2,
    }

    public enum DataFormat
    {
        HalfFloat = 0,
        Float = 1,
    }

    public enum ProbePositionMode
    {
        CellCorner = 0,
        CellCenter = 1,
    }

    public enum QualityMode
    {
        Low = 0,
        Normal = 1,
    }

    public enum RefreshMode
    {
        Automatic = 0,
        EveryFrame = 1,
        ViaScripting = 2,
    }

    public enum ResolutionMode
    {
        Automatic = 0,
        Custom = 1,
    }

}

}
