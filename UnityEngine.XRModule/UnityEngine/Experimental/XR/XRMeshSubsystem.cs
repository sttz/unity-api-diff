using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public class XRMeshSubsystem : Experimental.IntegratedSubsystem<Experimental.XR.XRMeshSubsystemDescriptor>
{
    public XRMeshSubsystem();

    public void GenerateMeshAsync(Experimental.XR.TrackableId meshId, Mesh mesh, MeshCollider meshCollider, Experimental.XR.MeshVertexAttributes attributes, Action<Experimental.XR.MeshGenerationResult> onMeshGenerationComplete);
    public bool TryGetMeshInfos(List<Experimental.XR.MeshInfo> meshInfosOut);

}

}
