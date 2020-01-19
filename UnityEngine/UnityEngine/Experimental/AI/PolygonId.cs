using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.AI
{

public struct PolygonId : IEquatable<Experimental.AI.PolygonId>
{
    public bool Equals(object obj);
    public bool Equals(Experimental.AI.PolygonId rhs);
    public int GetHashCode();
    public bool IsNull();

}

}
