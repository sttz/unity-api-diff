using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LightmapData
{
    public Texture2D lightmap { get; set; }
    public Texture2D lightmapColor { get; set; }
    public Texture2D lightmapDir { get; set; }
    public Texture2D lightmapFar { get; set; }
    public Texture2D lightmapLight { get; set; }
    public Texture2D lightmapNear { get; set; }
    public Texture2D shadowMask { get; set; }

    public LightmapData();

}

}
