using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class RenderSettings : Object
{
    static public Color ambientEquatorColor { get; set; }
    static public Color ambientGroundColor { get; set; }
    static public float ambientIntensity { get; set; }
    static public Color ambientLight { get; set; }
    static public Rendering.AmbientMode ambientMode { get; set; }
    static public Rendering.SphericalHarmonicsL2 ambientProbe { get; set; }
    static public float ambientSkyboxAmount { get; set; }
    static public Color ambientSkyColor { get; set; }
    static public Cubemap customReflection { get; set; }
    static public Rendering.DefaultReflectionMode defaultReflectionMode { get; set; }
    static public int defaultReflectionResolution { get; set; }
    static public float flareFadeSpeed { get; set; }
    static public float flareStrength { get; set; }
    static public bool fog { get; set; }
    static public Color fogColor { get; set; }
    static public float fogDensity { get; set; }
    static public float fogEndDistance { get; set; }
    static public FogMode fogMode { get; set; }
    static public float fogStartDistance { get; set; }
    static public float haloStrength { get; set; }
    static public int reflectionBounces { get; set; }
    static public float reflectionIntensity { get; set; }
    static public Material skybox { get; set; }
    static public Color subtractiveShadowColor { get; set; }
    static public Light sun { get; set; }

}

}
