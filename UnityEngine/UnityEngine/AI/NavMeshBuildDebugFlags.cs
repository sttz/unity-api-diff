using System;
using UnityEngine;

namespace UnityEngine.AI
{

public enum NavMeshBuildDebugFlags
{
    None = 0,
    InputGeometry = 1,
    Voxels = 2,
    Regions = 4,
    RawContours = 8,
    SimplifiedContours = 16,
    PolygonMeshes = 32,
    PolygonMeshesDetail = 64,
    All = 127,
}

}
