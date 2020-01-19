using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public enum FormatUsage
{
    Sample = 0,
    Linear = 1,
    Sparse = 2,
    Render = 4,
    Blend = 5,
    GetPixels = 6,
    SetPixels = 7,
    ReadPixels = 8,
    LoadStore = 9,
    MSAA2x = 10,
    MSAA4x = 11,
    MSAA8x = 12,
}

}
