using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct RenderQueueRange : IEquatable<Rendering.RenderQueueRange>
{
    static public int maximumBound;
    static public int minimumBound;

    static public Rendering.RenderQueueRange all { get; }
    static public Rendering.RenderQueueRange opaque { get; }
    static public Rendering.RenderQueueRange transparent { get; }

    public int lowerBound { get; set; }
    public int upperBound { get; set; }

    public RenderQueueRange(int lowerBound, int upperBound);

    public bool Equals(Rendering.RenderQueueRange other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
