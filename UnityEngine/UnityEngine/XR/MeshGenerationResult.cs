using System;
using UnityEngine;

namespace UnityEngine.XR
{

public struct MeshGenerationResult : IEquatable<XR.MeshGenerationResult>
{
    public XR.MeshVertexAttributes Attributes { get; }
    public Mesh Mesh { get; }
    public MeshCollider MeshCollider { get; }
    public XR.MeshId MeshId { get; }
    public XR.MeshGenerationStatus Status { get; }

    public bool Equals(object obj);
    public bool Equals(XR.MeshGenerationResult other);
    public int GetHashCode();

}

}
