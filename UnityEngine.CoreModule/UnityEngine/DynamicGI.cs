using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class DynamicGI
{
    static public float indirectScale { get; set; }
    static public bool isConverged { get; }
    static public int materialUpdateTimeSlice { get; set; }
    static public bool synchronousMode { get; set; }
    static public float updateThreshold { get; set; }

    static public void SetEmissive(Renderer renderer, Color color);
    static public void SetEnvironmentData(float[] input);
    static public void UpdateEnvironment();
    static public void UpdateMaterials(Object renderer);
    static public void UpdateMaterials(Renderer renderer);
    static public void UpdateMaterials(Object renderer, int x, int y, int width, int height);

    public DynamicGI();

}

}
