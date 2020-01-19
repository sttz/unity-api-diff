using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{

public struct ShaderCompilerData
{
    public Rendering.PlatformKeywordSet platformKeywordSet;
    public Rendering.ShaderKeywordSet shaderKeywordSet;

    public Rendering.GraphicsTier graphicsTier { get; }
    public UnityEditor.Rendering.ShaderCompilerPlatform shaderCompilerPlatform { get; }
    public UnityEditor.Rendering.ShaderRequirements shaderRequirements { get; }

}

}
