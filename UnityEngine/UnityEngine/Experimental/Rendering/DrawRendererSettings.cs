using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct DrawRendererSettings
{
    static public int maxShaderPasses;

    public Experimental.Rendering.DrawRendererFlags flags;
    public Experimental.Rendering.RendererConfiguration rendererConfiguration;
    public Experimental.Rendering.DrawRendererSortSettings sorting;

    public DrawRendererSettings(Camera camera, Experimental.Rendering.ShaderPassName shaderPassName);

    public void SetOverrideMaterial(Material mat, int passIndex);
    public void SetShaderPassName(int index, Experimental.Rendering.ShaderPassName shaderPassName);

    public struct <shaderPassNames>__FixedBuffer7
    {
        public int FixedElementField;

    }

}

}
