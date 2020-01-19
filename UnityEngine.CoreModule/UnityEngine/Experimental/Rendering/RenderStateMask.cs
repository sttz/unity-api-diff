using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public enum RenderStateMask
{
    Nothing = 0,
    Blend = 1,
    Raster = 2,
    Depth = 4,
    Stencil = 8,
    Everything = 15,
}

}
