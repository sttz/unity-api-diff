using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SpeedTreeImporter : UnityEditor.AssetImporter
{
    static public string[] windQualityNames;

    public float alphaTestRef { get; set; }
    public bool animateCrossFading { get; set; }
    public int bestWindQuality { get; }
    public float billboardTransitionCrossFadeWidth { get; set; }
    public bool[] castShadows { get; set; }
    public Shader defaultBillboardShader { get; }
    public Shader defaultShader { get; }
    public bool[] enableBump { get; set; }
    public bool[] enableHue { get; set; }
    public bool enableSmoothLODTransition { get; set; }
    public bool[] enableSubsurface { get; set; }
    public float fadeOutWidth { get; set; }
    public bool hasBillboard { get; }
    public bool hasImported { get; }
    public Color hueVariation { get; set; }
    public bool isV8 { get; }
    public float[] LODHeights { get; set; }
    public Color mainColor { get; set; }
    public string materialFolderPath { get; }
    public MaterialLocation materialLocation { get; set; }
    public bool[] receiveShadows { get; set; }
    public Rendering.ReflectionProbeUsage[] reflectionProbeUsages { get; set; }
    public float scaleFactor { get; set; }
    public float shininess { get; set; }
    public Color specColor { get; set; }
    public bool[] useLightProbes { get; set; }
    public int[] windQualities { get; set; }

    public SpeedTreeImporter();

    public void GenerateMaterials();
    public bool SearchAndRemapMaterials(string materialFolderPath);

    public enum MaterialLocation
    {
        External = 0,
        InPrefab = 1,
    }

}

}
