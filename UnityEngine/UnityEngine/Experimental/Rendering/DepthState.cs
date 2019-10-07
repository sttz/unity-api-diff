using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct DepthState
{
    static public Experimental.Rendering.DepthState Default { get; }

    public Rendering.CompareFunction compareFunction { get; set; }
    public bool writeEnabled { get; set; }

    public DepthState(bool writeEnabled = true, Rendering.CompareFunction compareFunction = 2);

}

}
