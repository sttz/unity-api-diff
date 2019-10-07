using System;
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
    Holes = 64,
    DelayedHolesUpdate = 128,
    WillBeDestroyed = 256,
}

}
