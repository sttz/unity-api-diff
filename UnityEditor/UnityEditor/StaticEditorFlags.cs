using System;
using UnityEngine;

namespace UnityEditor
{

public enum StaticEditorFlags
{
    ContributeGI = 1,
    OccluderStatic = 2,
    OccludeeStatic = 16,
    BatchingStatic = 4,
    NavigationStatic = 8,
    OffMeshLinkGeneration = 32,
    ReflectionProbeStatic = 64,
    LightmapStatic = 1,
}

}
