using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct DepthState : IEquatable<Rendering.DepthState>
{
    static public Rendering.DepthState defaultValue { get; }

    public Rendering.CompareFunction compareFunction { get; set; }
    public bool writeEnabled { get; set; }

    public DepthState(bool writeEnabled = true, Rendering.CompareFunction compareFunction = 2);

    public bool Equals(object obj);
    public bool Equals(Rendering.DepthState other);
    public int GetHashCode();

}

}
