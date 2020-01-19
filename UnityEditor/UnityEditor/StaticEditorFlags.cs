using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum StaticEditorFlags
{
    LightmapStatic = 1,
    OccluderStatic = 2,
    BatchingStatic = 4,
    NavigationStatic = 8,
    OccludeeStatic = 16,
    OffMeshLinkGeneration = 32,
    ReflectionProbeStatic = 64,
}

}
