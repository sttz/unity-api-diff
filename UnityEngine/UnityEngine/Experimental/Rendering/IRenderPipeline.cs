using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public interface IRenderPipeline : IDisposable
{
    public bool disposed { get; }

    public void Render(Experimental.Rendering.ScriptableRenderContext renderContext, Camera[] cameras);

}

}
