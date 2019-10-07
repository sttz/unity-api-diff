using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct FilterRenderersSettings
{
    public bool excludeMotionVectorObjects { get; set; }
    public int layerMask { get; set; }
    public uint renderingLayerMask { get; set; }
    public Experimental.Rendering.RenderQueueRange renderQueueRange { get; set; }

    public FilterRenderersSettings(bool initializeValues = false);

}

}
