using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR
{

public struct MeshInfo : IEquatable<XR.MeshInfo>
{
    public XR.MeshChangeState ChangeState { get; set; }
    public XR.MeshId MeshId { get; set; }
    public int PriorityHint { get; set; }

    public bool Equals(object obj);
    public bool Equals(XR.MeshInfo other);
    public int GetHashCode();

}

}
