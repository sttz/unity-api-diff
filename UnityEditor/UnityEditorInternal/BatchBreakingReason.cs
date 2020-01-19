using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public enum BatchBreakingReason
{
    NoBreaking = 0,
    NotCoplanarWithCanvas = 1,
    CanvasInjectionIndex = 2,
    DifferentMaterialInstance = 4,
    DifferentRectClipping = 8,
    DifferentTexture = 16,
    DifferentA8TextureUsage = 32,
    DifferentClipRect = 64,
    Unknown = 128,
}

}
