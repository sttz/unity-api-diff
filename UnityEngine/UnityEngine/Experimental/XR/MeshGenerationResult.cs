using System;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct MeshGenerationResult : IEquatable<Experimental.XR.MeshGenerationResult>
{
    public Experimental.XR.MeshVertexAttributes Attributes { get; }
    public Mesh Mesh { get; }
    public MeshCollider MeshCollider { get; }
    public Experimental.XR.TrackableId MeshId { get; }
    public Experimental.XR.MeshGenerationStatus Status { get; }

    public bool Equals(object obj);
    public bool Equals(Experimental.XR.MeshGenerationResult other);
    public int GetHashCode();

}

}
