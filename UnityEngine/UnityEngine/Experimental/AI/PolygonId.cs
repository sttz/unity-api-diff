using System;
using UnityEngine;

namespace UnityEngine.Experimental.AI
{

public struct PolygonId : IEquatable<Experimental.AI.PolygonId>
{
    public bool Equals(Experimental.AI.PolygonId rhs);
    public bool Equals(object obj);
    public int GetHashCode();
    public bool IsNull();

}

}
