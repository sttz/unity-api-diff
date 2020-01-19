using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TextCore
{

public struct GlyphRect : IEquatable<TextCore.GlyphRect>
{
    static public TextCore.GlyphRect zero { get; }

    public int height { get; set; }
    public int width { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public GlyphRect(Rect rect);
    public GlyphRect(int x, int y, int width, int height);

    public bool Equals(object obj);
    public bool Equals(TextCore.GlyphRect other);
    public int GetHashCode();

}

}
