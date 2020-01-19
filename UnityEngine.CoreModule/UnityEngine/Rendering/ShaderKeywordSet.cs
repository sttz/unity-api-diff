using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ShaderKeywordSet
{
    public void Disable(Rendering.ShaderKeyword keyword);
    public void Enable(Rendering.ShaderKeyword keyword);
    public Rendering.ShaderKeyword[] GetShaderKeywords();
    public bool IsEnabled(Rendering.ShaderKeyword keyword);

    public struct <m_Bits>e__FixedBuffer
    {
        public uint FixedElementField;

    }

}

}
