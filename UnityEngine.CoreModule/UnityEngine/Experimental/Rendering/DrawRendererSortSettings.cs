using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct DrawRendererSortSettings
{
    public Vector3 cameraCustomSortAxis;
    public Vector3 cameraPosition;
    public Experimental.Rendering.SortFlags flags;
    public Experimental.Rendering.DrawRendererSortMode sortMode;
    public Matrix4x4 worldToCameraMatrix;

    public bool sortOrthographic { get; set; }

}

}
