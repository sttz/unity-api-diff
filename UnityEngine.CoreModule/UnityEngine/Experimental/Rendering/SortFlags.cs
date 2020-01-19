using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public enum SortFlags
{
    None = 0,
    SortingLayer = 1,
    RenderQueue = 2,
    BackToFront = 4,
    QuantizedFrontToBack = 8,
    OptimizeStateChanges = 16,
    CommonTransparent = 23,
    CanvasOrder = 32,
    CommonOpaque = 59,
    RendererPriority = 64,
}

}
