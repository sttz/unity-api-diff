using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public class BatchRendererGroup : IDisposable
{
    public BatchRendererGroup(OnPerformCulling cullingCallback);

    public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, Rendering.ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, ulong sceneCullingMask = 9223372036854775808);
    public void Dispose();
    public Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrices(int batchIndex);
    public Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, string propertyName);
    public Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, int propertyName);
    public Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, string propertyName);
    public Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, int propertyName);
    public Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, string propertyName);
    public Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, int propertyName);
    public Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, string propertyName);
    public Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, int propertyName);
    public Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, string propertyName);
    public Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, int propertyName);
    public int GetNumBatches();
    public void RemoveBatch(int index);
    public void SetBatchBounds(int batchIndex, Bounds bounds);
    public void SetInstancingData(int batchIndex, int instanceCount, MaterialPropertyBlock customProps);

    public delegate Unity.Jobs.JobHandle OnPerformCulling(Rendering.BatchRendererGroup rendererGroup, Rendering.BatchCullingContext cullingContext);

}

}
