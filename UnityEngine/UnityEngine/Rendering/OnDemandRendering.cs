using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public class OnDemandRendering
{
    static public int effectiveRenderFrameRate { get; }
    static public int renderFrameInterval { get; set; }
    static public bool willCurrentFrameRender { get; }

    public OnDemandRendering();

}

}
