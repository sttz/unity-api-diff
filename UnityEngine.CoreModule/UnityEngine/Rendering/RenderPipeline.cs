using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public abstract class RenderPipeline
{
    static protected void BeginCameraRendering(Rendering.ScriptableRenderContext context, Camera camera);
    static protected void BeginContextRendering(Rendering.ScriptableRenderContext context, List<Camera> cameras);
    static protected void BeginFrameRendering(Rendering.ScriptableRenderContext context, Camera[] cameras);
    static protected void EndCameraRendering(Rendering.ScriptableRenderContext context, Camera camera);
    static protected void EndContextRendering(Rendering.ScriptableRenderContext context, List<Camera> cameras);
    static protected void EndFrameRendering(Rendering.ScriptableRenderContext context, Camera[] cameras);

    public bool disposed { get; private set; }

    protected RenderPipeline();

    protected void Dispose(bool disposing);
    protected void ProcessRenderRequests(Rendering.ScriptableRenderContext context, Camera camera, List<RenderRequest> renderRequests);
    protected void Render(Rendering.ScriptableRenderContext context, List<Camera> cameras);
    protected void Render(Rendering.ScriptableRenderContext context, Camera[] cameras);

}

}
