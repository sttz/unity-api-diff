using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRMeshSubsystem : IntegratedSubsystem<Experimental.XR.XRMeshSubsystemDescriptor>
{
    public float meshDensity { get; set; }

    public XRMeshSubsystem();

    public void GenerateMeshAsync(Experimental.XR.TrackableId meshId, Mesh mesh, MeshCollider meshCollider, Experimental.XR.MeshVertexAttributes attributes, Action<Experimental.XR.MeshGenerationResult> onMeshGenerationComplete);
    public bool SetBoundingVolume(Vector3 origin, Vector3 extents);
    public bool TryGetMeshInfos(System.Collections.Generic.List<Experimental.XR.MeshInfo> meshInfosOut);

}

}
