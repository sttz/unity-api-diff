using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum MeshColliderCookingOptions
{
    None = 0,
    InflateConvexMesh = 1,
    CookForFasterSimulation = 2,
    EnableMeshCleaning = 4,
    WeldColocatedVertices = 8,
}

}
