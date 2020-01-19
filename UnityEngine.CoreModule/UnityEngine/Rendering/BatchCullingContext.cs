using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct BatchCullingContext
{
    public Unity.Collections.NativeArray<Rendering.BatchVisibility> batchVisibility;
    public Unity.Collections.NativeArray<Plane> cullingPlanes;
    public Rendering.LODParameters lodParameters;
    public Unity.Collections.NativeArray<int> visibleIndices;

    public BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Rendering.LODParameters inLodParameters);

}

}
