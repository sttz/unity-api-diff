using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Mesh : Object
{
    public Matrix4x4[] bindposes { get; set; }
    public int blendShapeCount { get; }
    public BoneWeight[] boneWeights { get; set; }
    public Bounds bounds { get; set; }
    public Color[] colors { get; set; }
    public Color32[] colors32 { get; set; }
    public Rendering.IndexFormat indexFormat { get; set; }
    public bool isReadable { get; }
    public Vector3[] normals { get; set; }
    public int subMeshCount { get; set; }
    public Vector4[] tangents { get; set; }
    public int[] triangles { get; set; }
    public Vector2[] uv { get; set; }
    public Vector2[] uv1 { get; set; }
    public Vector2[] uv2 { get; set; }
    public Vector2[] uv3 { get; set; }
    public Vector2[] uv4 { get; set; }
    public Vector2[] uv5 { get; set; }
    public Vector2[] uv6 { get; set; }
    public Vector2[] uv7 { get; set; }
    public Vector2[] uv8 { get; set; }
    public int vertexBufferCount { get; }
    public int vertexCount { get; }
    public Vector3[] vertices { get; set; }

    public Mesh();

    public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents);
    public void Clear(bool keepVertexLayout);
    public void Clear();
    public void ClearBlendShapes();
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes);
    public void CombineMeshes(CombineInstance[] combine);
    public Unity.Collections.NativeArray<BoneWeight1> GetAllBoneWeights();
    public uint GetBaseVertex(int submesh);
    public void GetBindposes(System.Collections.Generic.List<Matrix4x4> bindposes);
    public int GetBlendShapeFrameCount(int shapeIndex);
    public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents);
    public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
    public int GetBlendShapeIndex(string blendShapeName);
    public string GetBlendShapeName(int shapeIndex);
    public Unity.Collections.NativeArray<byte> GetBonesPerVertex();
    public void GetBoneWeights(System.Collections.Generic.List<BoneWeight> boneWeights);
    public void GetColors(System.Collections.Generic.List<Color> colors);
    public void GetColors(System.Collections.Generic.List<Color32> colors);
    public uint GetIndexCount(int submesh);
    public uint GetIndexStart(int submesh);
    public int[] GetIndices(int submesh);
    public int[] GetIndices(int submesh, bool applyBaseVertex);
    public void GetIndices(System.Collections.Generic.List<int> indices, int submesh);
    public void GetIndices(System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex);
    public IntPtr GetNativeIndexBufferPtr();
    public IntPtr GetNativeVertexBufferPtr(int index);
    public void GetNormals(System.Collections.Generic.List<Vector3> normals);
    public void GetTangents(System.Collections.Generic.List<Vector4> tangents);
    public MeshTopology GetTopology(int submesh);
    public int[] GetTriangles(int submesh);
    public int[] GetTriangles(int submesh, bool applyBaseVertex);
    public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
    public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex);
    public float GetUVDistributionMetric(int uvSetIndex);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector2> uvs);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector3> uvs);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector4> uvs);
    public void GetVertices(System.Collections.Generic.List<Vector3> vertices);
    public void MarkDynamic();
    public void Optimize();
    public void OptimizeIndexBuffers();
    public void OptimizeReorderVertexBuffer();
    public void RecalculateBounds();
    public void RecalculateNormals();
    public void RecalculateTangents();
    public void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<BoneWeight1> weights);
    public void SetColors(System.Collections.Generic.List<Color> inColors);
    public void SetColors(System.Collections.Generic.List<Color32> inColors);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
    public void SetNormals(System.Collections.Generic.List<Vector3> inNormals);
    public void SetTangents(System.Collections.Generic.List<Vector4> inTangents);
    public void SetTriangles(int[] triangles, int submesh);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector2> uvs);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector3> uvs);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector4> uvs);
    public void SetVertices(System.Collections.Generic.List<Vector3> inVertices);
    public void UploadMeshData(bool markNoLongerReadable);

}

}
