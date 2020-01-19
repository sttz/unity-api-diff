using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct SortingLayerRange : IEquatable<Rendering.SortingLayerRange>
{
    static public Rendering.SortingLayerRange all { get; }

    public short lowerBound { get; set; }
    public short upperBound { get; set; }

    public SortingLayerRange(short lowerBound, short upperBound);

    public bool Equals(object obj);
    public bool Equals(Rendering.SortingLayerRange other);
    public int GetHashCode();

}

}
