using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public static class RenderPipelineManager
{
    static public Experimental.Rendering.IRenderPipeline currentPipeline { get; private set; }

}

}
