using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class MeshRenderer : Renderer
{
    public Mesh additionalVertexStreams { get; set; }
    public ReceiveGI receiveGI { get; set; }
    public float scaleInLightmap { get; set; }
    public bool stitchLightmapSeams { get; set; }
    public int subMeshStartIndex { get; }

    public MeshRenderer();

}

}
