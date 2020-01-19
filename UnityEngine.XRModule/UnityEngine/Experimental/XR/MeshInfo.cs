using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct MeshInfo : IEquatable<Experimental.XR.MeshInfo>
{
    public Experimental.XR.MeshChangeState ChangeState { get; set; }
    public Experimental.XR.TrackableId MeshId { get; set; }
    public int PriorityHint { get; set; }

    public bool Equals(object obj);
    public bool Equals(Experimental.XR.MeshInfo other);
    public int GetHashCode();

}

}
