using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum SortingCriteria
{
    None = 0,
    SortingLayer = 1,
    RenderQueue = 2,
    BackToFront = 4,
    QuantizedFrontToBack = 8,
    OptimizeStateChanges = 16,
    CanvasOrder = 32,
    RendererPriority = 64,
    CommonOpaque = 59,
    CommonTransparent = 23,
}

}
