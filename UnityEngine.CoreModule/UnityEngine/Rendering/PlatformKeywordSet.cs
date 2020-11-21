using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct PlatformKeywordSet
{
    public void Disable(Rendering.BuiltinShaderDefine define);
    public void Enable(Rendering.BuiltinShaderDefine define);
    public bool IsEnabled(Rendering.BuiltinShaderDefine define);

}

}
