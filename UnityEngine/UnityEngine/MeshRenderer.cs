using System;
using UnityEngine;

namespace UnityEngine
{

public class MeshRenderer : Renderer
{
    public Mesh additionalVertexStreams { get; set; }
    public Mesh enlightenVertexStream { get; set; }
    public ReceiveGI receiveGI { get; set; }
    public int subMeshStartIndex { get; }

    public MeshRenderer();

}

}
