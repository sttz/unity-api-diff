using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public sealed class GraphicsSettings : Object
{
    static public bool lightsUseColorTemperature { get; set; }
    static public bool lightsUseLinearIntensity { get; set; }
    static public bool realtimeDirectRectangularAreaLights { get; set; }
    static public Rendering.RenderPipelineAsset renderPipelineAsset { get; set; }
    static public Vector3 transparencySortAxis { get; set; }
    static public TransparencySortMode transparencySortMode { get; set; }
    static public bool useScriptableRenderPipelineBatching { get; set; }

    static public Shader GetCustomShader(Rendering.BuiltinShaderType type);
    static public Rendering.BuiltinShaderMode GetShaderMode(Rendering.BuiltinShaderType type);
    static public bool HasShaderDefine(Rendering.BuiltinShaderDefine defineHash);
    static public bool HasShaderDefine(Rendering.GraphicsTier tier, Rendering.BuiltinShaderDefine defineHash);
    static public void SetCustomShader(Rendering.BuiltinShaderType type, Shader shader);
    static public void SetShaderMode(Rendering.BuiltinShaderType type, Rendering.BuiltinShaderMode mode);

}

}
