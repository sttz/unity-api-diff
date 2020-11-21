using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.TextCore.LowLevel
{

public struct GlyphPairAdjustmentRecord
{
    public TextCore.LowLevel.FontFeatureLookupFlags featureLookupFlags { get; set; }
    public TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
    public TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }

    public GlyphPairAdjustmentRecord(TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord, TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord);

}

}
