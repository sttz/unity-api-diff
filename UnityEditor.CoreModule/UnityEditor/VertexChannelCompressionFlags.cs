using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum VertexChannelCompressionFlags
{
    None = 0,
    Position = 1,
    kPosition = 1,
    Normal = 2,
    kNormal = 2,
    Tangent = 4,
    kColor = 4,
    Color = 8,
    kUV0 = 8,
    TexCoord0 = 16,
    kUV1 = 16,
    TexCoord1 = 32,
    kUV2 = 32,
    TexCoord2 = 64,
    kUV3 = 64,
    TexCoord3 = 128,
    kTangent = 128,
}

}
