using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{

public enum ShaderRequirements : long
{
    None = 0,
    BaseShaders = 1,
    Interpolators10 = 2,
    Interpolators32 = 4,
    MRT4 = 8,
    MRT8 = 16,
    Derivatives = 32,
    SampleLOD = 64,
    FragCoord = 128,
    Interpolators15Integers = 512,
    Texture2DArray = 1024,
    Instancing = 2048,
    Geometry = 4096,
    CubeArray = 8192,
    Compute = 16384,
    RandomWrite = 32768,
    TessellationCompute = 65536,
    TessellationShaders = 131072,
    SparseTexelResident = 262144,
    FramebufferFetch = 524288,
    MSAATextureSamples = 1048576,
}

}
