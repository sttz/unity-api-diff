using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public abstract class RenderPipeline
{
    static protected void BeginCameraRendering(Rendering.ScriptableRenderContext context, Camera camera);
    static protected void BeginFrameRendering(Rendering.ScriptableRenderContext context, Camera[] cameras);
    static protected void EndCameraRendering(Rendering.ScriptableRenderContext context, Camera camera);
    static protected void EndFrameRendering(Rendering.ScriptableRenderContext context, Camera[] cameras);

    public bool disposed { get; private set; }

    protected RenderPipeline();

    protected void Dispose(bool disposing);
    protected void Render(Rendering.ScriptableRenderContext context, Camera[] cameras);

}

}
