using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum ShadowMapPass
{
    PointlightPositiveX = 1,
    PointlightNegativeX = 2,
    PointlightPositiveY = 4,
    PointlightNegativeY = 8,
    PointlightPositiveZ = 16,
    PointlightNegativeZ = 32,
    Pointlight = 63,
    DirectionalCascade0 = 64,
    DirectionalCascade1 = 128,
    DirectionalCascade2 = 256,
    DirectionalCascade3 = 512,
    Directional = 960,
    Spotlight = 1024,
    All = 2047,
}

}
