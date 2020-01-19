using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct VertexAttributeDescriptor : IEquatable<Rendering.VertexAttributeDescriptor>
{
    public Rendering.VertexAttribute attribute { get; set; }
    public int dimension { get; set; }
    public Rendering.VertexAttributeFormat format { get; set; }
    public int stream { get; set; }

    public VertexAttributeDescriptor(Rendering.VertexAttribute attribute = 0, Rendering.VertexAttributeFormat format = 0, int dimension = 3, int stream = 0);

    public bool Equals(object other);
    public bool Equals(Rendering.VertexAttributeDescriptor other);
    public int GetHashCode();
    public string ToString();

}

}
