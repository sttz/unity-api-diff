using System;
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
