using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class LightProbes : Object
{
    static public void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, Rendering.SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes);
    static public void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<Vector3> positions, System.Collections.Generic.List<Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<Vector4> occlusionProbes);
    static public void GetInterpolatedProbe(Vector3 position, Renderer renderer, out Rendering.SphericalHarmonicsL2 probe);

    public Rendering.SphericalHarmonicsL2[] bakedProbes { get; set; }
    public int cellCount { get; }
    public float[] coefficients { get; set; }
    public int count { get; }
    public Vector3[] positions { get; }

    public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients);

}

}
