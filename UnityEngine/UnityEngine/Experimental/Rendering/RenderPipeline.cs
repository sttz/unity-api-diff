using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class RenderPipeline
{
    static public event Action<Camera> beginCameraRendering;
    static public event Action<Camera[]> beginFrameRendering;

}

}