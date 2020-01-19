using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct RenderQueueRange
{
    static public Experimental.Rendering.RenderQueueRange all { get; }
    static public Experimental.Rendering.RenderQueueRange opaque { get; }
    static public Experimental.Rendering.RenderQueueRange transparent { get; }

    public int max;
    public int min;

}

}
