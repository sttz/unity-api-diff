using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class MeshUtility
{
    static public MeshDataArray AcquireReadOnlyMeshData(Mesh mesh);
    static public MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes);
    static public MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes);
    static public UnityEditor.ModelImporterMeshCompression GetMeshCompression(Mesh mesh);
    static public void Optimize(Mesh mesh);
    static public void SetMeshCompression(Mesh mesh, UnityEditor.ModelImporterMeshCompression compression);
    static public void SetPerTriangleUV2(Mesh src, Vector2[] triUV);

    public MeshUtility();

}

}
