using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TextCore.LowLevel
{

public struct GlyphAdjustmentRecord
{
    public uint glyphIndex { get; set; }
    public TextCore.LowLevel.GlyphValueRecord glyphValueRecord { get; set; }

    public GlyphAdjustmentRecord(uint glyphIndex, TextCore.LowLevel.GlyphValueRecord glyphValueRecord);

}

}
