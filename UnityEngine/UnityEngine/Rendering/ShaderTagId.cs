using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ShaderTagId : IEquatable<Rendering.ShaderTagId>
{
    static public Rendering.ShaderTagId none;

    public string name { get; }

    public ShaderTagId(string name);

    public bool Equals(object obj);
    public bool Equals(Rendering.ShaderTagId other);
    public int GetHashCode();

}

}
