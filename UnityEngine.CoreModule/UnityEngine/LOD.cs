using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct LOD
{
    public float fadeTransitionWidth;
    public Renderer[] renderers;
    public float screenRelativeTransitionHeight;

    public LOD(float screenRelativeTransitionHeight, Renderer[] renderers);

}

}
