using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum TerrainChangedFlags
{
    Heightmap = 1,
    TreeInstances = 2,
    DelayedHeightmapUpdate = 4,
    FlushEverythingImmediately = 8,
    RemoveDirtyDetailsImmediately = 16,
    HeightmapResolution = 32,
    WillBeDestroyed = 256,
}

}
