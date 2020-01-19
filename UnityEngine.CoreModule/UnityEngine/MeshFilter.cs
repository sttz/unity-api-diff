using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class MeshFilter : Component
{
    public Mesh mesh { get; set; }
    public Mesh sharedMesh { get; set; }

    public MeshFilter();

}

}
