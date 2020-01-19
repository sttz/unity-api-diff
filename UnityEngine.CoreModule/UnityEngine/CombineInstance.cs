using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct CombineInstance
{
    public Vector4 lightmapScaleOffset { get; set; }
    public Mesh mesh { get; set; }
    public Vector4 realtimeLightmapScaleOffset { get; set; }
    public int subMeshIndex { get; set; }
    public Matrix4x4 transform { get; set; }

}

}
