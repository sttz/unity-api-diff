using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public struct LODParameters
{
    public int cameraPixelHeight { get; set; }
    public Vector3 cameraPosition { get; set; }
    public float fieldOfView { get; set; }
    public bool isOrthographic { get; set; }
    public float orthoSize { get; set; }

}

}
