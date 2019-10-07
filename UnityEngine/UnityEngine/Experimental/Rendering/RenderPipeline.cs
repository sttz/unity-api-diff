using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public abstract class RenderPipeline : Experimental.Rendering.IRenderPipeline, IDisposable
{
    static public event Action<Camera> beginCameraRendering;
    static public event Action<Camera[]> beginFrameRendering;

    static public void BeginCameraRendering(Camera camera);
    static public void BeginFrameRendering(Camera[] cameras);

    public bool disposed { get; private set; }

    protected RenderPipeline();

    public void Dispose();
    public void Render(Experimental.Rendering.ScriptableRenderContext renderContext, Camera[] cameras);

}

}
