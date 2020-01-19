using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct RenderStateMapping
{
    public string renderType { get; set; }
    public Experimental.Rendering.RenderStateBlock stateBlock { get; set; }

    public RenderStateMapping(Experimental.Rendering.RenderStateBlock stateBlock);
    public RenderStateMapping(string renderType, Experimental.Rendering.RenderStateBlock stateBlock);

}

}
