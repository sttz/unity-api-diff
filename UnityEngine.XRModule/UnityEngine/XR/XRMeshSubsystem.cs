using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public class XRMeshSubsystem : IntegratedSubsystem<XR.XRMeshSubsystemDescriptor>
{
    public float meshDensity { get; set; }

    public XRMeshSubsystem();

    public void GenerateMeshAsync(XR.MeshId meshId, Mesh mesh, MeshCollider meshCollider, XR.MeshVertexAttributes attributes, Action<XR.MeshGenerationResult> onMeshGenerationComplete);
    public bool SetBoundingVolume(Vector3 origin, Vector3 extents);
    public bool TryGetMeshInfos(List<XR.MeshInfo> meshInfosOut);

}

}
