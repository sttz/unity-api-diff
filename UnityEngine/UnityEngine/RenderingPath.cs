using System;
using UnityEngine;

namespace UnityEngine
{

public enum RenderingPath
{
    UsePlayerSettings = -1,
    VertexLit = 0,
    Forward = 1,
    DeferredLighting = 2,
    DeferredShading = 3,
}

}
