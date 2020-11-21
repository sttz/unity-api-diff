using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct BatchCullingContext
{
    public Unity.Collections.NativeArray<Rendering.BatchVisibility> batchVisibility;
    public Matrix4x4 cullingMatrix;
    public Unity.Collections.NativeArray<Plane> cullingPlanes;
    public Rendering.LODParameters lodParameters;
    public float nearPlane;
    public Unity.Collections.NativeArray<int> visibleIndices;
    public Unity.Collections.NativeArray<int> visibleIndicesY;

    public BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Rendering.LODParameters inLodParameters);
    public BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Rendering.LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane);

}

}
