using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class ShaderWarmup
{
    static public void WarmupShader(Shader shader, Experimental.Rendering.ShaderWarmupSetup setup);
    static public void WarmupShaderFromCollection(ShaderVariantCollection collection, Shader shader, Experimental.Rendering.ShaderWarmupSetup setup);

}

}
