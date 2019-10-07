using System;
using UnityEngine;

namespace UnityEngine.XR
{

public struct MeshId : IEquatable<XR.MeshId>
{
    static public XR.MeshId InvalidId { get; }

    public bool Equals(object obj);
    public bool Equals(XR.MeshId other);
    public int GetHashCode();
    public string ToString();

}

}
