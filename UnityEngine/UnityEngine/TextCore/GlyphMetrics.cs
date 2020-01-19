using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TextCore
{

public struct GlyphMetrics : IEquatable<TextCore.GlyphMetrics>
{
    public float height { get; set; }
    public float horizontalAdvance { get; set; }
    public float horizontalBearingX { get; set; }
    public float horizontalBearingY { get; set; }
    public float width { get; set; }

    public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);

    public bool Equals(object obj);
    public bool Equals(TextCore.GlyphMetrics other);
    public int GetHashCode();

}

}
