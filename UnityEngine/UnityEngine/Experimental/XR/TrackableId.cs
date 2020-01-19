using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.XR
{

public struct TrackableId : IEquatable<Experimental.XR.TrackableId>
{
    static public Experimental.XR.TrackableId InvalidId { get; }

    public bool Equals(object obj);
    public bool Equals(Experimental.XR.TrackableId other);
    public int GetHashCode();
    public string ToString();

}

}
