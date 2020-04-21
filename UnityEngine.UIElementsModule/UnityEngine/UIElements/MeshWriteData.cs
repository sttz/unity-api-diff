using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MeshWriteData
{
    public int indexCount { get; }
    public Rect uvRegion { get; }
    public int vertexCount { get; }

    public void SetAllIndices(ushort[] indices);
    public void SetAllIndices(Unity.Collections.NativeSlice<ushort> indices);
    public void SetAllVertices(Unity.Collections.NativeSlice<UIElements.Vertex> vertices);
    public void SetAllVertices(UIElements.Vertex[] vertices);
    public void SetNextIndex(ushort index);
    public void SetNextVertex(UIElements.Vertex vertex);

}

}
