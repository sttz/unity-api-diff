using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum BuiltinRenderTextureType
{
    PropertyName = -4,
    BufferPtr = -3,
    RenderTexture = -2,
    BindableTexture = -1,
    None = 0,
    CurrentActive = 1,
    CameraTarget = 2,
    Depth = 3,
    DepthNormals = 4,
    ResolvedDepth = 5,
    PrepassNormalsSpec = 7,
    PrepassLight = 8,
    PrepassLightSpec = 9,
    GBuffer0 = 10,
    GBuffer1 = 11,
    GBuffer2 = 12,
    GBuffer3 = 13,
    Reflections = 14,
    MotionVectors = 15,
    GBuffer4 = 16,
    GBuffer5 = 17,
    GBuffer6 = 18,
    GBuffer7 = 19,
}

}
