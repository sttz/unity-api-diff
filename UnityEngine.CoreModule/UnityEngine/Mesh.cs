using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class Mesh : Object
{
    static public MeshDataArray AcquireReadOnlyMeshData(Mesh mesh);
    static public MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes);
    static public MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes);
    static public MeshDataArray AllocateWritableMeshData(int meshCount);
    static public void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh mesh, Rendering.MeshUpdateFlags flags = 0);
    static public void ApplyAndDisposeWritableMeshData(MeshDataArray data, List<Mesh> meshes, Rendering.MeshUpdateFlags flags = 0);
    static public void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh[] meshes, Rendering.MeshUpdateFlags flags = 0);

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
    public void Clear();
    public void Clear(bool keepVertexLayout);
    public void ClearBlendShapes();
    public void CombineMeshes(CombineInstance[] combine);
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes);
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
    public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
    public Unity.Collections.NativeArray<BoneWeight1> GetAllBoneWeights();
    public uint GetBaseVertex(int submesh);
    public void GetBindposes(List<Matrix4x4> bindposes);
    public int GetBlendShapeFrameCount(int shapeIndex);
    public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents);
    public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
    public int GetBlendShapeIndex(string blendShapeName);
    public string GetBlendShapeName(int shapeIndex);
    public Unity.Collections.NativeArray<byte> GetBonesPerVertex();
    public void GetBoneWeights(List<BoneWeight> boneWeights);
    public void GetColors(List<Color> colors);
    public void GetColors(List<Color32> colors);
    public uint GetIndexCount(int submesh);
    public uint GetIndexStart(int submesh);
    public int[] GetIndices(int submesh);
    public void GetIndices(List<int> indices, int submesh);
    public int[] GetIndices(int submesh, bool applyBaseVertex);
    public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex);
    public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = true);
    public IntPtr GetNativeIndexBufferPtr();
    public IntPtr GetNativeVertexBufferPtr(int index);
    public void GetNormals(List<Vector3> normals);
    public Rendering.SubMeshDescriptor GetSubMesh(int index);
    public void GetTangents(List<Vector4> tangents);
    public MeshTopology GetTopology(int submesh);
    public int[] GetTriangles(int submesh);
    public int[] GetTriangles(int submesh, bool applyBaseVertex);
    public void GetTriangles(List<int> triangles, int submesh);
    public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex);
    public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = true);
    public float GetUVDistributionMetric(int uvSetIndex);
    public void GetUVs(int channel, List<Vector2> uvs);
    public void GetUVs(int channel, List<Vector3> uvs);
    public void GetUVs(int channel, List<Vector4> uvs);
    public Rendering.VertexAttributeDescriptor GetVertexAttribute(int index);
    public int GetVertexAttributeDimension(Rendering.VertexAttribute attr);
    public Rendering.VertexAttributeFormat GetVertexAttributeFormat(Rendering.VertexAttribute attr);
    public Rendering.VertexAttributeDescriptor[] GetVertexAttributes();
    public int GetVertexAttributes(List<Rendering.VertexAttributeDescriptor> attributes);
    public int GetVertexAttributes(Rendering.VertexAttributeDescriptor[] attributes);
    public void GetVertices(List<Vector3> vertices);
    public bool HasVertexAttribute(Rendering.VertexAttribute attr);
    public void MarkDynamic();
    public void MarkModified();
    public void Optimize();
    public void OptimizeIndexBuffers();
    public void OptimizeReorderVertexBuffer();
    public void RecalculateBounds();
    public void RecalculateBounds(Rendering.MeshUpdateFlags flags);
    public void RecalculateNormals();
    public void RecalculateNormals(Rendering.MeshUpdateFlags flags);
    public void RecalculateTangents();
    public void RecalculateTangents(Rendering.MeshUpdateFlags flags);
    public void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<BoneWeight1> weights);
    public void SetColors(List<Color> inColors);
    public void SetColors(List<Color32> inColors);
    public void SetColors(Color[] inColors);
    public void SetColors(Color32[] inColors);
    public void SetColors(List<Color> inColors, int start, int length);
    public void SetColors(List<Color32> inColors, int start, int length);
    public void SetColors(Color[] inColors, int start, int length);
    public void SetColors(Color32[] inColors, int start, int length);
    public void SetColors(List<Color> inColors, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetColors(List<Color32> inColors, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetColors(Color[] inColors, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetColors(Color32[] inColors, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetColors<T>(Unity.Collections.NativeArray<T> inColors);
    public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length);
    public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetIndexBufferParams(int indexCount, Rendering.IndexFormat format);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds);
    public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
    public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetNormals(List<Vector3> inNormals);
    public void SetNormals(Vector3[] inNormals);
    public void SetNormals(List<Vector3> inNormals, int start, int length);
    public void SetNormals(Vector3[] inNormals, int start, int length);
    public void SetNormals(List<Vector3> inNormals, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetNormals(Vector3[] inNormals, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals);
    public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length);
    public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetSubMesh(int index, Rendering.SubMeshDescriptor desc, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes(List<Rendering.SubMeshDescriptor> desc, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes(Rendering.SubMeshDescriptor[] desc, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes(List<Rendering.SubMeshDescriptor> desc, int start, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes(Rendering.SubMeshDescriptor[] desc, int start, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, Rendering.MeshUpdateFlags flags = 0);
    public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, Rendering.MeshUpdateFlags flags = 0);
    public void SetTangents(List<Vector4> inTangents);
    public void SetTangents(Vector4[] inTangents);
    public void SetTangents(List<Vector4> inTangents, int start, int length);
    public void SetTangents(Vector4[] inTangents, int start, int length);
    public void SetTangents(List<Vector4> inTangents, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetTangents(Vector4[] inTangents, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents);
    public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length);
    public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetTriangles(List<int> triangles, int submesh);
    public void SetTriangles(int[] triangles, int submesh);
    public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
    public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
    public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0);
    public void SetUVs(int channel, List<Vector2> uvs);
    public void SetUVs(int channel, List<Vector3> uvs);
    public void SetUVs(int channel, List<Vector4> uvs);
    public void SetUVs(int channel, Vector2[] uvs);
    public void SetUVs(int channel, Vector3[] uvs);
    public void SetUVs(int channel, Vector4[] uvs);
    public void SetUVs(int channel, List<Vector2> uvs, int start, int length);
    public void SetUVs(int channel, List<Vector3> uvs, int start, int length);
    public void SetUVs(int channel, List<Vector4> uvs, int start, int length);
    public void SetUVs(int channel, Vector2[] uvs, int start, int length);
    public void SetUVs(int channel, Vector3[] uvs, int start, int length);
    public void SetUVs(int channel, Vector4[] uvs, int start, int length);
    public void SetUVs(int channel, List<Vector2> uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs(int channel, List<Vector3> uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs(int channel, List<Vector4> uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs(int channel, Vector2[] uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs(int channel, Vector3[] uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs(int channel, Vector4[] uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs);
    public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length);
    public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, Rendering.MeshUpdateFlags flags = 0);
    public void SetVertexBufferParams(int vertexCount, Rendering.VertexAttributeDescriptor[] attributes);
    public void SetVertices(List<Vector3> inVertices);
    public void SetVertices(Vector3[] inVertices);
    public void SetVertices(List<Vector3> inVertices, int start, int length);
    public void SetVertices(Vector3[] inVertices, int start, int length);
    public void SetVertices(List<Vector3> inVertices, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetVertices(Vector3[] inVertices, int start, int length, Rendering.MeshUpdateFlags flags);
    public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices);
    public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length);
    public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, Rendering.MeshUpdateFlags flags);
    public void UploadMeshData(bool markNoLongerReadable);

    public struct MeshData
    {
        public Rendering.IndexFormat indexFormat { get; }
        public int subMeshCount { get; set; }
        public int vertexBufferCount { get; }
        public int vertexCount { get; }

        public void GetColors(Unity.Collections.NativeArray<Color> outColors);
        public void GetColors(Unity.Collections.NativeArray<Color32> outColors);
        public Unity.Collections.NativeArray<T> GetIndexData<T>();
        public void GetIndices(Unity.Collections.NativeArray<int> outIndices, int submesh, bool applyBaseVertex = true);
        public void GetIndices(Unity.Collections.NativeArray<ushort> outIndices, int submesh, bool applyBaseVertex = true);
        public void GetNormals(Unity.Collections.NativeArray<Vector3> outNormals);
        public Rendering.SubMeshDescriptor GetSubMesh(int index);
        public void GetTangents(Unity.Collections.NativeArray<Vector4> outTangents);
        public void GetUVs(int channel, Unity.Collections.NativeArray<Vector2> outUVs);
        public void GetUVs(int channel, Unity.Collections.NativeArray<Vector3> outUVs);
        public void GetUVs(int channel, Unity.Collections.NativeArray<Vector4> outUVs);
        public int GetVertexAttributeDimension(Rendering.VertexAttribute attr);
        public Rendering.VertexAttributeFormat GetVertexAttributeFormat(Rendering.VertexAttribute attr);
        public Unity.Collections.NativeArray<T> GetVertexData<T>(int stream = 0);
        public void GetVertices(Unity.Collections.NativeArray<Vector3> outVertices);
        public bool HasVertexAttribute(Rendering.VertexAttribute attr);
        public void SetIndexBufferParams(int indexCount, Rendering.IndexFormat format);
        public void SetSubMesh(int index, Rendering.SubMeshDescriptor desc, Rendering.MeshUpdateFlags flags = 0);
        public void SetVertexBufferParams(int vertexCount, Rendering.VertexAttributeDescriptor[] attributes);

    }

    public struct MeshDataArray : IDisposable
    {
        public MeshData this[int index] { get; }
        public int Length { get; }

        public void Dispose();

    }

}

}
