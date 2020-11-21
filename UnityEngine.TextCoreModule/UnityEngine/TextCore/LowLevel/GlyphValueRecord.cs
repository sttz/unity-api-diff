using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TextCore.LowLevel
{

public struct GlyphValueRecord : IEquatable<TextCore.LowLevel.GlyphValueRecord>
{
    public float xAdvance { get; set; }
    public float xPlacement { get; set; }
    public float yAdvance { get; set; }
    public float yPlacement { get; set; }

    public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);

    public bool Equals(object obj);
    public bool Equals(TextCore.LowLevel.GlyphValueRecord other);
    public int GetHashCode();

}

}
