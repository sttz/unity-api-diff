using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D
{

public struct SpriteAtlasPackingSettings
{
    public int blockOffset { get; set; }
    public bool enableAlphaDilation { get; set; }
    public bool enableRotation { get; set; }
    public bool enableTightPacking { get; set; }
    public int padding { get; set; }

}

}
