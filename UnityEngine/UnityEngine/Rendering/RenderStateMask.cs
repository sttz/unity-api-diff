using System;
using UnityEngine;

namespace UnityEngine.Rendering
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
