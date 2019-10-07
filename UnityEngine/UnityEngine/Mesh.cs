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
    public int vertexAttributeCount { get; }
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
    public void GetIndices(System.Collections.Generic.List<ushort> indices, int submesh, bool applyBaseVertex = true);
    public IntPtr GetNativeIndexBufferPtr();
    public IntPtr GetNativeVertexBufferPtr(int index);
    public void GetNormals(System.Collections.Generic.List<Vector3> normals);
    public Rendering.SubMeshDescriptor GetSubMesh(int index);
    public void GetTangents(System.Collections.Generic.List<Vector4> tangents);
    public MeshTopology GetTopology(int submesh);
    public int[] GetTriangles(int submesh);
    public int[] GetTriangles(int submesh, bool applyBaseVertex);
    public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
    public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex);
    public void GetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool applyBaseVertex = true);
    public float GetUVDistributionMetric(int uvSetIndex);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector2> uvs);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector3> uvs);
    public void GetUVs(int channel, System.Collections.Generic.List<Vector4> uvs);
    public Rendering.VertexAttributeDescriptor GetVertexAttribute(int index);
    public int GetVertexAttributeDimension(Rendering.VertexAttribute attr);
    public Rendering.VertexAttributeFormat GetVertexAttributeFormat(Rendering.VertexAttribute attr);
    public Rendering.VertexAttributeDescriptor[] GetVertexAttributes();
    public int GetVertexAttributes(Rendering.VertexAttributeDescriptor[] attributes);
    public int GetVertexAttributes(System.Collections.Generic.List<Rendering.VertexAttributeDescriptor> attributes);
    public void GetVertices(System.Collections.Generic.List<Vector3> vertices);
    public bool HasVertexAttribute(Rendering.VertexAttribute attr);
    public void MarkDynamic();
    public void MarkModified();
    public void Optimize();
    public void OptimizeIndexBuffers();
    public void OptimizeReorderVertexBuffer();
    public void RecalculateBounds();
    public void RecalculateNormals();
    public void RecalculateTangents();
    public void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<BoneWeight1> weights);
    public void SetColors(System.Collections.Generic.List<Color> inColors);
    public void SetColors(System.Collections.Generic.List<Color> inColors, int start, int length);
    public void SetColors(Color[] inColors);
    public void SetColors(Color[] inColors, int start, int length);
    public void SetColors(System.Collections.Generic.List<Color32> inColors);
    public void SetColors(System.Collections.Generic.List<Color32> inColors, int start, int length);
    public void SetColors(Color32[] inColors);
    public void SetColors(Color32[] inColors, int start, int length);
    public void SetColors(Unity.Collections.NativeArray<T> inColors);
    public void SetColors(Unity.Collections.NativeArray<T> inColors, int start, int length);
    public void SetIndexBufferData(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferData(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferParams(int indexCount, Rendering.IndexFormat format);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
    public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(System.Collections.Generic.List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(System.Collections.Generic.List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(System.Collections.Generic.List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetNormals(System.Collections.Generic.List<Vector3> inNormals);
    public void SetNormals(System.Collections.Generic.List<Vector3> inNormals, int start, int length);
    public void SetNormals(Vector3[] inNormals);
    public void SetNormals(Vector3[] inNormals, int start, int length);
    public void SetNormals(Unity.Collections.NativeArray<T> inNormals);
    public void SetNormals(Unity.Collections.NativeArray<T> inNormals, int start, int length);
    public void SetSubMesh(int index, Rendering.SubMeshDescriptor desc, Rendering.MeshUpdateFlags flags = 0);
    public void SetTangents(System.Collections.Generic.List<Vector4> inTangents);
    public void SetTangents(System.Collections.Generic.List<Vector4> inTangents, int start, int length);
    public void SetTangents(Vector4[] inTangents);
    public void SetTangents(Vector4[] inTangents, int start, int length);
    public void SetTangents(Unity.Collections.NativeArray<T> inTangents);
    public void SetTangents(Unity.Collections.NativeArray<T> inTangents, int start, int length);
    public void SetTriangles(int[] triangles, int submesh);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(System.Collections.Generic.List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector2> uvs);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector3> uvs);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector4> uvs);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector2> uvs, int start, int length);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector3> uvs, int start, int length);
    public void SetUVs(int channel, System.Collections.Generic.List<Vector4> uvs, int start, int length);
    public void SetUVs(int channel, Vector2[] uvs);
    public void SetUVs(int channel, Vector3[] uvs);
    public void SetUVs(int channel, Vector4[] uvs);
    public void SetUVs(int channel, Vector2[] uvs, int start, int length);
    public void SetUVs(int channel, Vector3[] uvs, int start, int length);
    public void SetUVs(int channel, Vector4[] uvs, int start, int length);
    public void SetUVs(int channel, Unity.Collections.NativeArray<T> uvs);
    public void SetUVs(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length);
    public void SetVertexBufferData(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferData(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferParams(int vertexCount, Rendering.VertexAttributeDescriptor[] attributes);
    public void SetVertices(System.Collections.Generic.List<Vector3> inVertices);
    public void SetVertices(System.Collections.Generic.List<Vector3> inVertices, int start, int length);
    public void SetVertices(Vector3[] inVertices);
    public void SetVertices(Vector3[] inVertices, int start, int length);
    public void SetVertices(Unity.Collections.NativeArray<T> inVertices);
    public void SetVertices(Unity.Collections.NativeArray<T> inVertices, int start, int length);
    public void UploadMeshData(bool markNoLongerReadable);

}

}
