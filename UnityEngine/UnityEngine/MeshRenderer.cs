using System;
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
