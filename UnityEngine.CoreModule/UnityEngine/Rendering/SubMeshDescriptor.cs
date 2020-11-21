using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct SubMeshDescriptor
{
    public int baseVertex { get; set; }
    public Bounds bounds { get; set; }
    public int firstVertex { get; set; }
    public int indexCount { get; set; }
    public int indexStart { get; set; }
    public MeshTopology topology { get; set; }
    public int vertexCount { get; set; }

    public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = 0);

    public string ToString();

}

}
