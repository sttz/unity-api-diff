using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental
{

public sealed class Lightmapping
{
    static public bool extractAmbientOcclusion { get; set; }
    static public bool probesIgnoreDirectEnvironment { get; set; }

    static public event Action additionalBakedProbesCompleted;

    static public bool Bake(SceneManagement.Scene scene);
    static public bool BakeAsync(SceneManagement.Scene scene);
    static public bool GetAdditionalBakedProbes(int id, Unity.Collections.NativeArray<Rendering.SphericalHarmonicsL2> outBakedProbeSH, Unity.Collections.NativeArray<float> outBakedProbeValidity);
    static public bool GetCustomBakeResults(out Vector4[] results);
    static public void SetAdditionalBakedProbes(int id, Vector3[] positions);
    static public void SetCustomBakeInputs(Vector4[] inputData, int sampleCount);

    public Lightmapping();

}

}
