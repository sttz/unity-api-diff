using System;
using UnityEngine;

namespace UnityEditor
{

public enum VertexChannelCompressionFlags
{
    None = 0,
    Position = 1,
    Normal = 2,
    Tangent = 4,
    Color = 8,
    TexCoord0 = 16,
    TexCoord1 = 32,
    TexCoord2 = 64,
    TexCoord3 = 128,
    kPosition = 1,
    kNormal = 2,
    kColor = 4,
    kUV0 = 8,
    kUV1 = 16,
    kUV2 = 32,
    kUV3 = 64,
    kTangent = 128,
}

}
