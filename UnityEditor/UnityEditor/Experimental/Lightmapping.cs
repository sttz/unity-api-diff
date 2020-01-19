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

    static public bool GetCustomBakeResults(out Vector4[] results);
    static public void SetCustomBakeInputs(Vector4[] inputData, int sampleCount);

    public Lightmapping();

}

}
