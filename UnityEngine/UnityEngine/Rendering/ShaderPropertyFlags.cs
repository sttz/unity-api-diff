using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum ShaderPropertyFlags
{
    None = 0,
    HideInInspector = 1,
    PerRendererData = 2,
    NoScaleOffset = 4,
    Normal = 8,
    HDR = 16,
    Gamma = 32,
    NonModifiableTextureData = 64,
}

}
