using System;
using UnityEngine;

namespace UnityEngine.TextCore
{

public class Glyph
{
    public int atlasIndex { get; set; }
    public TextCore.GlyphRect glyphRect { get; set; }
    public uint index { get; set; }
    public TextCore.GlyphMetrics metrics { get; set; }
    public float scale { get; set; }

    public Glyph();
    public Glyph(TextCore.Glyph glyph);
    public Glyph(uint index, TextCore.GlyphMetrics metrics, TextCore.GlyphRect glyphRect);
    public Glyph(uint index, TextCore.GlyphMetrics metrics, TextCore.GlyphRect glyphRect, float scale, int atlasIndex);

    public bool Compare(TextCore.Glyph other);

}

}
