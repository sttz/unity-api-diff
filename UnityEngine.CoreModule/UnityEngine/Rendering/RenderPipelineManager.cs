using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public static class RenderPipelineManager
{
    static public Rendering.RenderPipeline currentPipeline { get; private set; }

    static public event Action<Rendering.ScriptableRenderContext, Camera> beginCameraRendering;
    static public event Action<Rendering.ScriptableRenderContext, Camera[]> beginFrameRendering;
    static public event Action<Rendering.ScriptableRenderContext, Camera> endCameraRendering;
    static public event Action<Rendering.ScriptableRenderContext, Camera[]> endFrameRendering;

}

}
