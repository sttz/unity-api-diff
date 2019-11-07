using System;
using UnityEngine;

namespace UnityEditor.U2D
{

public struct SpriteAtlasTextureSettings
{
    public int anisoLevel { get; set; }
    public FilterMode filterMode { get; set; }
    public bool generateMipMaps { get; set; }
    public bool readable { get; set; }
    public bool sRGB { get; set; }

}

}
