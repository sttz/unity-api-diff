using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class MeshRenderer : Renderer
{
    public Mesh additionalVertexStreams { get; set; }
    public int subMeshStartIndex { get; }

    public MeshRenderer();

}

}